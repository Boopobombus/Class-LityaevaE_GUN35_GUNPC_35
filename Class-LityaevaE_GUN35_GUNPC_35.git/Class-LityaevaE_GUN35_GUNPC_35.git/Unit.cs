using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_LityaevaE_GUN35_GUNPC_35.git
{
    public class Unit
    {
        private float _health;
        private float _armor;
        private int _damage;
        public string Name { get; }
        public float Health => _health;
        public Unit() : this(name: "Unknown Unit")
        {
        }
        public Unit(string name)
        {
            Name = name;
        }
        public float RealHealth()
        { 
            return Health * (1 + Armor); 
        }
        public float Armor
        {
            get { return (float) Math.Round(_armor, 2); }
            set 
            {
            if (value >=0 || value <=1)
                {
                    _armor = value;
                     }
            else { }
            }
        }
        public int Damage
        { 
            get {return _damage = 5; } 
        }
        public bool SetDamage (float value)
        {
            
            _health = Health - value * _armor;
            return _health >= 0;
        }
        
    }
}