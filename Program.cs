namespace Tugas_Abstract_Class_dan_Interface
{ 

    class Program
    { 
        static void Main(string[] args)
        {
        // Setelan karakter pemain
        Player player = new Player("Pemain", 90, 40, 10);

        // Setelan musuh
        Enemy enemy = new Enemy("Musuh", 85, 15);

        // Setelan skill
        Skill healSkill = new Heal(35);
        Skill fireballSkill = new Fireball(25);
        Skill iceBlastSkill = new IceBlast(40, 5);

        // Pemain menyerang musuh
        player.GunakanSkill(enemy);

        // Musuh menyerang pemain
        enemy.GunakanSkill(player);

        // Pemain menggunakan skill Heal pada dirinya sendiri
        healSkill.GunakanSkill(player);

        // Pemain menggunakan skill Fireball pada musuh
        fireballSkill.GunakanSkill(enemy);

        // Musuh menggunakan skill Ice Blast pada pemain
        iceBlastSkill.GunakanSkill(player);
        }
    }
}