namespace Console.src.Entities
{
    public class Knight : Hero
    {
        
          public Knight(string Name, int Level, String HeroType, int MP, int HP): base(Name, Level, HeroType, MP, HP) 
            {
                this.Name = Name;
                this.Level = Level;
                this.HeroType = HeroType;
                this.MP = MP;
                this.HP =HP; 
        }
        
    }
}