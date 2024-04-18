using System;
namespace Tugas_Abstract_Class_dan_Interface
{

    class Enemy : Character
    {
        public Enemy(string nama, int hp, int kekuatan) : base(nama, hp, 0, kekuatan)
        {
        }

        public override void GunakanSkill(Character target)
        {
            Console.WriteLine($"{this.nama} menyerang {target.nama}");
            target.hp-= this.kekuatan;
            if (target.hp <= 0)
            {
                target.hp = 0;
                target.cetakInformasi();
                this.cetakInformasi();
                Die();
            }
            else
            {
                target.cetakInformasi();
            }
        }

        public override void cetakInformasi()
        {
            Console.WriteLine($" Musuh: {this.nama}\n HP: {this.hp}");
        }

        public void Die()
        {
            Console.WriteLine($"{this.nama} telah mati.");
        }
    }
}


