using System;
using System.Collections.Generic;
using System.Text;

namespace LightAndDieClasses
{
    class Die
    {
        // Methods
        public int Roll()
        {
            return generator.Next(1, numberOfEyes + 1);
        }

        public void SetNumberOfEyes(int eyes)
        {
            numberOfEyes = Math.Abs(eyes);
        }

        // Attributes
        private Random generator = new Random();
        private int numberOfEyes = 6;
    }
}
