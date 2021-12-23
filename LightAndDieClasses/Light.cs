using System;
using System.Collections.Generic;
using System.Text;

namespace LightAndDieClasses
{
    class Light
    {
        public void On()
        {
            isOn = true;
        }

        public void Off()
        {
            isOn = false;
        }

        // Attributes (state)
        public bool isOn = false;
    }
}
