using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Class_LityaevaE_GUN35_GUNPC_35.git
{
    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        
        
        public string Name { get; }
        public int MinDamage { get; private set; }
        public string MaxDamage { get; private set; }
        public float Durability { get; } = 1f;

        
        public Weapon(string name) : this("Sword", 1 , 10)
        { }
        public Weapon(string name, int minDamage, int maxDamage)
        { Name = name;
         
            minDamage = _minDamage;
            maxDamage = _maxDamage;
            
        }

        public void SetDamageParams (int _minDamage, int _maxDamage)
        {
            if (_minDamage>_maxDamage)
            { int a = _minDamage;
                _minDamage = _maxDamage;
                _maxDamage = a;
                Console.WriteLine($"Некорректные данные орудия {Name}, значения поменяли местами");
            }
            else
            {
                 if (_maxDamage<1)
                { _maxDamage = 10;
                    Console.WriteLine("Установлено значение 10 для максимального урона"); }
                else if ( _maxDamage<=1)
                { _maxDamage = 10;}
            }
           
        }
        public int GetDamage 
        {
            get { return (_minDamage + _minDamage) / 2; }
        }
        
        
    }
}