using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Abstract_Class_dan_Interface
{

    abstract class Character
    {
        public string nama;
        public int hp;
        public int mp;
        public int kekuatan;

        public Character(string nama, int hp, int mp, int kekuatan)
        {
            this.nama = nama;
            this.hp = hp;
            this.mp = mp;
            this.kekuatan = kekuatan;
        }

        public abstract void GunakanSkill(Character target);

        public abstract void cetakInformasi();
    }
}