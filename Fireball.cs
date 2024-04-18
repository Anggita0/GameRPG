using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Abstract_Class_dan_Interface
{
    class Fireball : Skill
    {
        private int damage;

        public Fireball(int damage)
        {
            this.damage = damage;
        }

        public void GunakanSkill(Character target)
        {
            Console.WriteLine($"Menggunakan skill Fireball pada {target.nama}");
            target.hp -= damage;
            if (target.hp <= 0)
            {
                target.hp = 0;
                target.cetakInformasi();
                Console.WriteLine($"{target.nama} telah mati");
            }
            else
            {
                target.cetakInformasi();
            }
        }
    }
}
