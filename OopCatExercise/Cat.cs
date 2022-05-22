using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace OopCatExercise
{

    public abstract class Cat : ICat
    {

        public bool IsAsleep { get; private set; } = false;
        public int AverageHeight { get; private set; }
        public string Setting { get; private set; }
        public Cat(int averagehiegh, string setting)
        {
            AverageHeight = averagehiegh;
            Setting = setting;
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }
        public abstract string Eat();

    } 
}



