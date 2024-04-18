using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Abstract_Class_dan_Interface
{
    class Heal : Skill
    {
        private int healAmount;

        public Heal(int healAmount)
        {
            this.healAmount = healAmount;
        }

        public void GunakanSkill(Character target)
        {
            Console.WriteLine($"{target.nama} Menggunakan skill Healnya");
            target.hp += healAmount;
            target.cetakInformasi();
        }
    }
}
