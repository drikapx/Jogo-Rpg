namespace Console.src.Entities
{
   
using System;

    internal class Program
    {
        static void Main(string[] args){
        
    
         Knight arus = new Knight ("Arus" , 23 , "Knight" , 72 , 749);
         Wizard Wizard = new Wizard ("Jennica" , 23 , "write Wizard",482,601);
         Ninja Wedge = new Ninja ("Wedge" , 42 , "Ninja",89,574);
         DarkWizard Topapa = new DarkWizard ("Topapa" , 42 , "Dark Wizard",641,385);
        
         Console.WriteLine(arus.Attack());
         Console.WriteLine(Wizard.Attack(7));
         Console.WriteLine(Wedge.Attack(75));
         Console.WriteLine(Topapa.Attack(87));

        }
           
       
    }        
}   

