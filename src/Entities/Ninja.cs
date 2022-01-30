namespace Console.src.Entities
{
    public class Ninja : Hero
    {
        
         public Ninja(string Name, int Level, String HeroType, int MP, int HP): base(Name, Level, HeroType, MP, HP) 
            {
                this.Name = Name;
                this.Level = Level;
                this.HeroType = HeroType;
                this.MP = MP;
                this.HP =HP; 
        }
         public override string Attack(){
              return this.Name + " " + "Socou e Chutou";
          }
          public string Attack(int Bonus){
              if (Bonus > 6){
                  return this.Name + " " + "Chutou varias vezes com bonus de " + Bonus;

                }else{
                  return this.Name + " " + "Ele apenas Socou " + Bonus;
                }

        }
    }
}