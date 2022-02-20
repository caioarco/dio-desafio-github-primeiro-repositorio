namespace GFT_Start___Desafio_RPG.SRC.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HealthPoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.ManaPoints = ManaPoints;
        }


        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        public virtual string Attack()
        {
            return this.Name + " atacou com sua espada";
        }
    }
}