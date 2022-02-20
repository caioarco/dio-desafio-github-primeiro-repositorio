namespace GFT_Start___Desafio_RPG.SRC.Entities
{
    public class DarkWizard : Hero
    {
        public DarkWizard(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints) : base(Name, Level, HeroType, HealthPoints, ManaPoints)
        {
            
        }

     public string Attack(int Bonus)
        {
            if (Bonus > 15)
            {
                return this.Name + " conjurou uma magia massiva de dano, com bonus de " + Bonus; 
            }
            else if(Bonus < 5)
            {
                return this.Name + " conjurou uma magia de dano ínfimo, com bonus de " + Bonus; 
            }

            else
            {
                return this.Name + " conjurou uma magia de dano com bonus de " + Bonus; 
            }
        }
    }
}
       