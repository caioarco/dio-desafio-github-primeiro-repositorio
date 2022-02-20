using GFT_Start___Desafio_RPG.SRC.Entities;
using static System.Console;
class Program
{   
    
    static void Main()
    {
        Knight cloud = new Knight("Cloud", 1, "Soldier", 15, 0);
        Wizard aerith = new Wizard("Aerith", 1, "Cleric", 8, 5);
        Ninja tifa = new Ninja("Tifa", 1,"Fighter", 11, 0 );
        DarkWizard vincent = new DarkWizard ("Vincent", 1, "Black Mage", 7, 6);
        

        WriteLine(tifa.Attack(1));
        WriteLine(cloud.Attack(3));
        WriteLine(vincent.Attack(4));
        WriteLine(aerith.Attack(2));

    }   
}