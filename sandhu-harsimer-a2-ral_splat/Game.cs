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
        const int GROUND_Y = 220;
        const int HURT_FRAMES_APPLIED = 20;
        const int SPLAT_FRAMES_APPLIED = 90;
        const int HURT_DRAIN = 1;
        int hurt_timer = 0;
        int splat_timer = 0;
        Vector2 center_position = new Vector2(200, 200);


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // Basically the premise is that you "poke" Ralsie from Deltarune
            Window.SetTitle("Poke Ralsie");
            // The max size the assignement has mentioned
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Since pixels drawn don't get auto cleared on their own, we have to manually clear everything at the start of every frame
            Window.ClearBackground(Color.White);

            // TODO: While idle (no inputs pressed), we draw Ralsie's idle sprite at the center, facing towards the "camera", aka, you

            // TODO_2: If Mouse Left Click is detected within the specified range of Ralsie, `hurt_timer` gets increased by `HURT_FRAMES_APPLIED`
            // Continue; Then every frame lowers it by `HURT_DRAIN`, so once it reaches 0, Ralsie goes back to idle sprite, otherwise, stays in hurt sprite

            // TODO_3: If Mouse Right Click is held, Ralsie's center position is latched to the mouse for as long as Right Click is held. There should be a latched sprite when held
            // Continue; If the mouse lets go, Ralsie should start falling with increasing gravity. Upon landing, by reaching `GROUND_Y`, Ralsie will go into splat sprite
            // Continue; Ralsie will remain in that sprite until the timer `splat_timer` reaches 0, which initially get increased from `SPLAT_FRAMES_APPLIED`


            // TODO_4: Ralsie can't be interacted with until `splat_timer` reaches 0
        }
    }

}
