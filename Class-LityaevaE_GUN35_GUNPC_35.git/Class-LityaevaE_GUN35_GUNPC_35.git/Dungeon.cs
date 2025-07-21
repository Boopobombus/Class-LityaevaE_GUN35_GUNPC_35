using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_LityaevaE_GUN35_GUNPC_35.git
{
    public class Dungeon
    {
        Room[] room;

        public Dungeon()
        {
            room = new Room[5];

            for (int i = 0; i < room.Length; i++)
            {
                room[i] = new Room(
                new Unit($"Unit room + {i + 1}"),
                new Weapon($"Weapon room + {i + 1}", i + 1, i + 2));

            }
        }


        public void ShowRoom()
        {
        for ( int i = 0; i < room.Length; i++)
            { var rooms =  room[i];
            Console.WriteLine($"Unit of room + {rooms.UnitRef}" );
                Console.WriteLine($"Weapon of room + {rooms.WeaponRef}");
                Console.WriteLine("-");

            }         
        }
} }
