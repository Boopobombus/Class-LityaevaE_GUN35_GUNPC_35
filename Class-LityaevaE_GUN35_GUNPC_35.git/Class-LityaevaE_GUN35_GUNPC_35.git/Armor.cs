using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_LityaevaE_GUN35_GUNPC_35.git
{
    public class Helm
    {
public string Name { get;}
        public float Armor { get; set; }
        public Helm ( string name = "Helm")
                {  
                Name = name;
            }
            public Helm(float armor, string name = "Helm"): this (name)
                { 
                Armor = armor;
            }
    }

    public class Shell 
    {
        public string Name1 { get; }
        public float Armor1 { get; set; }
        public Shell (string name1 = "Shell")
        {
            Name1 = name1;
        }
        public Shell (float armor1, string name1 = "Shell") : this(name1)
        {
            Armor1 = armor1;
        }

    }

    public class Boots
    {
        public string Name2 { get; }
        public float Armor2 { get; set; }
        public Boots (string name2 = "Boots")
        {
            Name2 = name2;
        }
        public Boots (float armor2, string name2 = "Boots") : this(name2)
        {
            Armor2 = armor2;
        }

    }
}
