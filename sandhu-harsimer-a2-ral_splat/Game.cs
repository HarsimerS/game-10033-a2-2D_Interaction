// Include the namespaces (code libraries) you need below.
using Raylib_cs;
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
            
            // TODO_1: Have each number key change the color that would be used to draw shapes

            // TODO_2: Have the up and down arrow key change the width of the shape

            // TODO_3: Have Space Bar clear the background to white

            // TODO_4: Left click will draw a circle at mouse postion with the width var



        }
    }

}
