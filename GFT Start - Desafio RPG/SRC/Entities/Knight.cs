namespace GFT_Start___Desafio_RPG.SRC.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints) : base(Name, Level, HeroType, HealthPoints, ManaPoints)
        {
            
        }

     public string Attack(int Bonus)
        {
            if (Bonus > 15)
            {
                return this.Name + " desferiu um corte crítico com sua espada, com bonus de " + Bonus; 
            }
            else if (Bonus < 5)
            {
                return this.Name + " cortou superficialmente com sua espada, causa apenas o bonus de " + Bonus; 
            }
            else
            {
                return this.Name + " fez um corte bem sucedido, com bonus de " + Bonus;
            }
        }
    }
}