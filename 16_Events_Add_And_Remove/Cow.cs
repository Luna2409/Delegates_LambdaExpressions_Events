using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Events_Add_And_Remove
{
    class Cow
    {
        public event Action Mooing;
        //public event Action Mooing
        //{
        //    add
        //    {
        //        mooing += value;
        //    }
        //    remove
        //    {
        //        mooing -= value;
        //    }
        //}

        public void PushSleepingCow()
        {
            // ........
            if(Mooing != null)
                Mooing();
        }
    }
}
