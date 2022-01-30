namespace Console.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, String HeroType, int MP, int HP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.MP = MP;
            this.HP =HP; 
        }
        public String Name;
        public int Level;
        public string HeroType;
        public int MP;

        public int HP;


        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType+ " " + this.MP + " " + this.HP;
        }

        public virtual string Attack(){
            return this.Name +" "+ "Atacou com a sua espada";

        }
    }
}