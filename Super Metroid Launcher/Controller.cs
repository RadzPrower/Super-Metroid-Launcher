using SDL2;

namespace Super_Metroid_Launcher
{
    public class MyController
    {
        private readonly IntPtr controller;
        public bool connected = false;

        public MyController()
        {
            // Initialize SDL
            _ = SDL.SDL_Init(SDL.SDL_INIT_GAMECONTROLLER);

            // Check if any joysticks are connected
            if (SDL.SDL_NumJoysticks() > 0)
            {
                // Open the first joystick
                controller = SDL.SDL_GameControllerOpen(0);
                connected = true;
            }
        }

        public static string? GetButtonName()
        {
            SDL.SDL_PumpEvents();
            SDL.SDL_FlushEvents(SDL.SDL_EventType.SDL_FIRSTEVENT, SDL.SDL_EventType.SDL_LASTEVENT);

            var window = SDL.SDL_CreateWindow("Awaiting input...", Form.ActiveForm.Location.X + 292, Form.ActiveForm.Location.Y + 199, 150, 50,
                SDL.SDL_WindowFlags.SDL_WINDOW_INPUT_GRABBED |
                SDL.SDL_WindowFlags.SDL_WINDOW_BORDERLESS |
                SDL.SDL_WindowFlags.SDL_WINDOW_ALWAYS_ON_TOP);

            _ = SDL.SDL_ShowCursor(SDL.SDL_DISABLE);

            var leftTrigger = false;
            var rightTrigger = false;
            var stop = DateTime.Now.AddSeconds(5);

            while (true)
            {
                // Wait for an event to occur
                _ = SDL.SDL_PollEvent(out SDL.SDL_Event e);

                // Check for ESC key
                if (e.type == SDL.SDL_EventType.SDL_KEYDOWN)
                {
                    if (SDL.SDL_GetKeyName(e.key.keysym.sym) == "Escape")
                    {
                        SDL.SDL_DestroyWindow(window);
                        return null;
                    }
                }

                // Check for trigger axis event
                if (e.type == SDL.SDL_EventType.SDL_CONTROLLERAXISMOTION)
                {
                    if (e.caxis.axis == ((byte)SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_TRIGGERLEFT))
                    {
                        leftTrigger = true;
                    }
                    else if (e.caxis.axis == ((byte)SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_TRIGGERRIGHT))
                    {
                        rightTrigger = true;
                    }

                    if (e.caxis.axis == ((byte)SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_TRIGGERLEFT) && e.caxis.axisValue == 0 && leftTrigger)
                    {
                        SDL.SDL_DestroyWindow(window);
                        return "L2";
                    }
                    else if (e.caxis.axis == ((byte)SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_TRIGGERRIGHT) && e.caxis.axisValue == 0 && rightTrigger)
                    {
                        SDL.SDL_DestroyWindow(window);
                        return "R2";
                    }
                }

                // Check if the event was a controller button press
                if (e.type == SDL.SDL_EventType.SDL_CONTROLLERBUTTONDOWN)
                {
                    SDL.SDL_DestroyWindow(window);
                    return (ConvertButtonID(e.cbutton.button));
                }

                if (DateTime.Now >= stop)
                {
                    SDL.SDL_DestroyWindow(window);
                    return null;
                }
            }
        }

        internal static string? ConvertButtonID(byte button)
        {
            return button switch
            {
                0 => "A",
                1 => "B",
                2 => "X",
                3 => "Y",
                4 => "Back",
                5 => "Guide",
                6 => "Start",
                7 => "L3",
                8 => "R3",
                9 => "Lb",
                10 => "Rb",
                11 => "DPadUp",
                12 => "DPadDown",
                13 => "DPadLeft",
                14 => "DPadRight",
                _ => null,
            };
        }

        public void Close()
        {
            // Close the joystick and quit SDL
            SDL.SDL_GameControllerClose(controller);
            SDL.SDL_Quit();
        }
    }

}
