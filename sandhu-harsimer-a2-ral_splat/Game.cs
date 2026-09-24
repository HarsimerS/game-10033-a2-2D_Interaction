// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        // 0 == red, 1 == orange, 2 == yellow, 3 == green, 4 == blue, 5 == purple, 6 == gray, 7 == black, 8 == white
        int color_choice = 0;
        // width of the "brush"
        int width = 7;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Basically the premise is that you can draw with a software that could be used like "Can we use Krita?" "No we have Krita at home" *The Krita at home*
            Window.SetTitle("The drawing software at home");
            // The max size the assignement has mentioned
            Window.SetSize(400, 400);
            Window.ClearBackground(Color.White);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            bool is_left_clicking = Input.IsMouseButtonDown(MouseInput.Left);

            bool pressed_up = Input.IsKeyboardKeyPressed(KeyboardInput.Up);
            bool pressed_down = Input.IsKeyboardKeyPressed(KeyboardInput.Down);

            bool pressed_1 = Input.IsKeyboardKeyPressed(KeyboardInput.One);
            bool pressed_2 = Input.IsKeyboardKeyPressed(KeyboardInput.Two);
            bool pressed_3 = Input.IsKeyboardKeyPressed(KeyboardInput.Three);
            bool pressed_4 = Input.IsKeyboardKeyPressed(KeyboardInput.Four);
            bool pressed_5 = Input.IsKeyboardKeyPressed(KeyboardInput.Five);
            bool pressed_6 = Input.IsKeyboardKeyPressed(KeyboardInput.Six);
            bool pressed_7 = Input.IsKeyboardKeyPressed(KeyboardInput.Seven);
            bool pressed_8 = Input.IsKeyboardKeyPressed(KeyboardInput.Eight);
            bool pressed_9 = Input.IsKeyboardKeyPressed(KeyboardInput.Nine);

            // TODO_1: Have each number key change the color that would be used to draw shapes (DONE)

            // TODO_2: Have the up and down arrow key change the width of the shape (DONE)

            // TODO_3: Have Space Bar clear the background to white (DONE)

            // TODO_4: Left click will draw a circle at mouse postion with the width var (DONE)

            if (pressed_up == true)
            {
                width += 1;
            }

            // I have it check to make sure its atleast 1, or else you wouldnt be able to see the shapes at all
            if (pressed_down == true)
            {
                width -= 1;
                if (width < 1)
                {
                    width = 1;
                }
            }

            if (pressed_1 == true)
            {
                Draw.FillColor = Color.Red;
            }
            if (pressed_2 == true)
            {
                Draw.FillColor = new(255, 128, 0);
            }
            if (pressed_3 == true)
            {
                Draw.FillColor = Color.Yellow;
            }
            if (pressed_4 == true)
            {
                Draw.FillColor = Color.Green;
            }
            if (pressed_5 == true)
            {
                Draw.FillColor = Color.Blue;
            }
            if (pressed_6 == true)
            {
                Draw.FillColor = Color.Magenta;
            }
            if (pressed_7 == true)
            {
                Draw.FillColor = Color.Gray;
            }
            if (pressed_8 == true)
            {
                Draw.FillColor = Color.Black;
            }
            if (pressed_9 == true)
            {
                Draw.FillColor = Color.White;
            }

            // Need to use this, otherwise no matter the color, there would be a small black outline around each drawn shape
            Draw.LineColor = Draw.FillColor;

            // Since I need the drawn shapes and doodles to stay, I only have it clear it if Space is pressed
            bool space_click = Input.IsKeyboardKeyDown(KeyboardInput.Space);
            if (space_click == true)
            {
                Window.ClearBackground(Color.White);
            }

            if (is_left_clicking == true)
            {
                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), width);
            }

        }
    }

}
