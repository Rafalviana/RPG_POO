namespace POO_RPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + "Atacou com magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus >6)
            {
                return this.Name + "Atacou com magia forte de força " + Bonus;
            }
            else
            {
                return this.Name + "Atacou com magia fraca de força " + Bonus;
            }

        }
    }
}