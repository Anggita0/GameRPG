using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tugas_Abstract_Class_dan_Interface
{
    class Player : Character
    {
        public Player(string nama, int hp, int mp, int kekuatan) : base(nama, hp, mp, kekuatan)
        {
        }

        public override void GunakanSkill(Character target)
        {
            Console.WriteLine($"{this.nama} menyerang {target.nama}");
            target.hp -= this.kekuatan;
            if (target.hp <= 0)
            {
                target.hp = 0;
                target.cetakInformasi();
                this.cetakInformasi();

            }
            else
            {
                target.cetakInformasi();
            }
        }

        public override void cetakInformasi()
        {
            Console.WriteLine($" Character: {this.nama}\n HP: {this.hp}\n MP: {this.mp}");
        }
    }
}