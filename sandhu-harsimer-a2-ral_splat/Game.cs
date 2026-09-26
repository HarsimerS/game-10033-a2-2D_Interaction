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
        // width of the "brush"
        int width = 7;
        // Stores the selected color to be used to draw
        Color selected_col = new Color();

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
            selected_col = Color.Black;
            Draw.FillColor = selected_col;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            bool is_left_clicking = Input.IsMouseButtonDown(MouseInput.Left);

            bool pressed_up = Input.IsKeyboardKeyPressed(KeyboardInput.Up);
            bool pressed_down = Input.IsKeyboardKeyPressed(KeyboardInput.Down);
            // 1 == red, 2 == orange, 3 == yellow, 4 == green, 5 == blue, 6 == purple, 7 == gray, 8 == black, 9 == white
            bool pressed_1 = Input.IsKeyboardKeyPressed(KeyboardInput.One);
            bool pressed_2 = Input.IsKeyboardKeyPressed(KeyboardInput.Two);
            bool pressed_3 = Input.IsKeyboardKeyPressed(KeyboardInput.Three);
            bool pressed_4 = Input.IsKeyboardKeyPressed(KeyboardInput.Four);
            bool pressed_5 = Input.IsKeyboardKeyPressed(KeyboardInput.Five);
            bool pressed_6 = Input.IsKeyboardKeyPressed(KeyboardInput.Six);
            bool pressed_7 = Input.IsKeyboardKeyPressed(KeyboardInput.Seven);
            bool pressed_8 = Input.IsKeyboardKeyPressed(KeyboardInput.Eight);
            bool pressed_9 = Input.IsKeyboardKeyPressed(KeyboardInput.Nine);
            Color temp_color_holder = new Color();
            // Temp Color storage so the user's color choice doesn't get overwritten later
            float outline_size_holder = 1f;
            float offset = 2.44444444f;
            // TODO_1: Have each number key change the color that would be used to draw shapes (DONE)

            // TODO_2: Have the up and down arrow key change the width of the shape (DONE)

            // TODO_3: Have Space Bar clear the background to white (DONE)

            // TODO_4: Left click will draw a circle at mouse postion with the width var (DONE)

            // TODO_5: Show colors left to right order so people know which num key does what (DONE)
            temp_color_holder = selected_col;

            // This block here is for drawing colors red to white from left to right
            Draw.LineSize = 0.5f;
            Draw.FillColor = Color.Red;
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            Draw.FillColor = new(255, 128, 0);
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            Draw.FillColor = Color.Yellow;
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            Draw.FillColor = Color.Green;
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            Draw.FillColor = Color.Blue;
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            Draw.FillColor = Color.Magenta;
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            Draw.FillColor = Color.Gray;
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            Draw.FillColor = Color.Black;
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            Draw.FillColor = Color.White;
            Draw.Rectangle(offset, 375, 44, 25);
            offset += 44;
            // offset just makes it easier to space out each rectangle from each other
            
            // The initial picked color by the user is then restored
            Draw.FillColor = temp_color_holder;

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
                selected_col = Color.Red;
            }
            if (pressed_2 == true)
            {
                selected_col = new(255, 128, 0);
            }
            if (pressed_3 == true)
            {
                selected_col = Color.Yellow;
            }
            if (pressed_4 == true)
            {
                selected_col = Color.Green;
            }
            if (pressed_5 == true)
            {
                selected_col = Color.Blue;
            }
            if (pressed_6 == true)
            {
                selected_col = Color.Magenta;
            }
            if (pressed_7 == true)
            {
                selected_col = Color.Gray;
            }
            if (pressed_8 == true)
            {
                selected_col = Color.Black;
            }
            if (pressed_9 == true)
            {
                selected_col = Color.White;
            }

            // Need to use this, otherwise no matter the color, there would be a small black outline around each drawn shape
            Draw.LineColor = selected_col;
            Draw.LineSize = outline_size_holder;
            Draw.FillColor = selected_col;

            Draw.Rectangle(0, 0, 450, 5);

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
