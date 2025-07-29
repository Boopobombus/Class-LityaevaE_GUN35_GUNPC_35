using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Class_LityaevaE_GUN35_GUNPC_35.git
{
    public class Weapon
    {
        /*private int _minDamage;
        private int _maxDamage;*/
        public Interval NewDamage {  get; set; }
        
        
        public string Name { get; }
        
        public float Durability { get; } = 1f;

        
        public Weapon(string name) : this ("Sword", new Interval(1, 0))
        { }
        public Weapon(string name, Interval newDamage /*int minDamage, int maxDamage*/)
        { Name = name;
            newDamage = NewDamage;
            /*minDamage = _minDamage;
            maxDamage = _maxDamage;*/
            
        }
        /*
        public void SetDamageParams (int minDamage, int maxDamage)
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
           
        }*/
        public int GetDamage ()
        {
            return (minValue + maxValue ) / 2;
        }
        
        
    }
}