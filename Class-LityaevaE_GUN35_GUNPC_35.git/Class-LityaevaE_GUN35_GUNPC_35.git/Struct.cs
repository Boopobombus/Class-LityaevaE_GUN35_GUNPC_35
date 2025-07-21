using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Class_LityaevaE_GUN35_GUNPC_35.git
{
    public struct Internal

    {
        private int minValue;//поле
        private int maxValue;
        private float get;

        private float Get
        {
            get { return get; }
            set
            {
                Random rnd = new Random();
                int b = rnd.Next(minValue, maxValue);
            }
        }
        
        public Internal (int minValue,  int maxValue)
        { Min = minValue;
            Max = maxValue;
            
            if (Min>Max)
            { int a = Max;
                Max = Min;
                Min = a;
                            }
            else if (Max < 0)
                Max = 0;
            else if (Min < 0)
                Min = 0;

            else if (Min == Max)
            {
                Max = 10 * Max;
                Console.WriteLine("Некорректный ввод данных");
}

           
        }

        public int Min
        {
            get { return minValue; }
            set
            {
                if (minValue < 0)
                {
                    minValue = 0;
                }
                Console.WriteLine("Некорректый ввод данных");
            }
        }
        public int Max
        {
            get { return maxValue; }
            set {
                if (minValue < 0)
                {
                    minValue = 0;
                }
                Console.WriteLine("Некорректый ввод данных");
            }
        }
        
       
    }

    public struct Room
    {
        public Unit UnitRef;
        public Weapon WeaponRef;

        public Room(Unit unitRef, Weapon weaponRef)
        {
            this.UnitRef = unitRef;
            this.WeaponRef = weaponRef;
        }
    }
}
