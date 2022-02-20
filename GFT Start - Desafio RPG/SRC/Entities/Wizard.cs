namespace GFT_Start___Desafio_RPG.SRC.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints) : base(Name, Level, HeroType, HealthPoints, ManaPoints)
        {
            
        }
        public override string Attack()
        {
            return this.Name + " lançou magia" ;
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 15)
            {
                return this.Name + " lançou uma magia de cura super efetiva com bonus de " + Bonus; 
            }
            else if (Bonus < 5)
            {
                return this.Name + " lançou uma magia de cura com pouca eficiência, de bonus " + Bonus; 
            }
            else
            {
                return this.Name + " lançou uma magia de cura com sucesso, de bonus " + Bonus;
            }
        }
    }
}