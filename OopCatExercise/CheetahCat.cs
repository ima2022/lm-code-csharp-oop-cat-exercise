using System;

namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base(100, "wild")
        {
        }

        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
