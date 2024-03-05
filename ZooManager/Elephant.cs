﻿using System;
namespace ZooManager
{
    public class Elephant : Animal
    {
        public Elephant(string name)
        {
            emoji = "🐘";
            species = "elephant";
            this.name = name;
            reactionTime = new Random().Next(6, 10); // reaction time 6 to 9 (slow)
        }

        public override void Activate()
        {
            base.Activate();
            // Console.WriteLine("I am an elephant. Honk!.");
            /* This conditional uses the principle of "short-circuiting. It may look like it
             * calls two methods, but in fact, it calls the first method Flee(), and if it returns true,
             * the second method is never called because the OR statement is true. If Flee() returns
             * false, then Hunt() is called. If Hunt() returns false, the ! changes it to true. In other
             * words, if the Elephant Flees() or fails to Hunt() then SlowDown() is called
             */
            if (Flee() || !Hunt())
            {
                SlowDown();
            }
        }

        /* Our elephant is more afraid of mice than anything else, though!
         * Note that this version of Flee returns whether or not the elephant
         * successfully moved or not! The elephant can only hunt if it did not
         * spend its move fleeing!
         */

        public bool Flee()
        {
            if (Game.Seek(location.x, location.y, Direction.up, "mouse"))
            {
                if (Game.Retreat(this, Direction.down)) return true;
            }
            if (Game.Seek(location.x, location.y, Direction.down, "mouse"))
            {
                if (Game.Retreat(this, Direction.up)) return true;
            }
            if (Game.Seek(location.x, location.y, Direction.left, "mouse"))
            {
                if (Game.Retreat(this, Direction.right)) return true;
            }
            if (Game.Seek(location.x, location.y, Direction.right, "mouse"))
            {
                if (Game.Retreat(this, Direction.left)) return true;
            }
            return false;
        }

        /* Note the variations in how we handle the elephant going for grass
         * and for a rock. Also notice the use of return vs break.
         */

        public bool Hunt()
        {
            for (var i = 0; i < 4; i++)
            {
                if (Game.Seek(location.x, location.y, (Direction)i, "grass"))
                {
                    Game.Attack(this, (Direction)i);
                    return true; // end function early
                }
            }

            /* No grass? Look for a cat to stomp! */
            if (Game.Seek(location.x, location.y, Direction.up, "cat"))
            {
                Game.Attack(this, Direction.up);
                return true;
            }
            else if (Game.Seek(location.x, location.y, Direction.down, "cat"))
            {
                Game.Attack(this, Direction.down);
                return true;
            }
            else if (Game.Seek(location.x, location.y, Direction.left, "cat"))
            {
                Game.Attack(this, Direction.left);
                return true;
            }
            else if (Game.Seek(location.x, location.y, Direction.right, "cat"))
            {
                Game.Attack(this, Direction.right);
                return true;
            }
            else
            {
                /* No cats? Look for a boulder to stomp! */
                for (var i = 0; i < 4; i++)
                {
                    if (Game.Seek(location.x, location.y, (Direction)i, "boulder")) {
                        Game.Attack(this, (Direction)i);
                        return true; // end loop
                    }
                }
            }
            return false; // nothing to stomp!
        }
    }
}


