using System;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        private const double DismassiveRandomCount = 0;
        public DomesticCat() : base(23, "domestic")
        {
        }
        public override string Eat()
        {
            DisplyDismassiveCommentCountRandomly(DismassiveRandomCount);
            return "Purrrrrrr";
        }
        private void DisplyDismassiveCommentCountRandomly(double count)
        {
            Random random = new Random();
             if (random.NextDouble() > count)
                Console.WriteLine("It will do I Suppose");
        }
    }
}
