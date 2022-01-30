namespace Console.src.Entities
{
    public class DarkWizard : Hero
    {
       public DarkWizard(string Name, int Level, String HeroType, int MP, int HP): base(Name, Level, HeroType, MP, HP) 
            {
                this.Name = Name;
                this.Level = Level;
                this.HeroType = HeroType;
                this.MP = MP;
                this.HP =HP; 
            }
          public override string Attack(){
              return this.Name + " " + "lançou uma magia";
          }
          public string Attack(int Bonus){
              if (Bonus > 6){
                  return this.Name + " " + "lançou uma dark magic super efetiva com bonus de " + Bonus;

                }else{
                  return this.Name + " " + "lançou uma dark magic com bonus de ataque de " + Bonus;
                }
        }
    }
 
 } 
    
