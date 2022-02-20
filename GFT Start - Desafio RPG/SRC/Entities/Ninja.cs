namespace GFT_Start___Desafio_RPG.SRC.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints) : base(Name, Level, HeroType, HealthPoints, ManaPoints)
        {
            
        }

     public string Attack(int Bonus)
        {
            if (Bonus > 15)
            {
                return this.Name + " acertou um ponto vital em cheio! com bonus de " + Bonus; 
            }
            else if (Bonus < 5)
            {
                return this.Name + " acertou de raspão, restando um bonus de " + Bonus; 
            }
            else
            {
                return this.Name + " acertou seu chute com bonus de " + Bonus;
            }
        }
    }
}