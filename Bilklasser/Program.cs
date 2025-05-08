// See https://aka.ms/new-console-template for more information

namespace bilklasser;
                                   
 class Bil
 {
     public string Brand;
     public string Modell;
     public string Color;
     public string NewColor;
     public int Kilometerstand;
     public bool ErMotorStartet;
                                   
     public void StartMotor()
     {
         ErMotorStartet = true;
         Console.WriteLine($"Motoren til {Brand} {Modell} er startet.");
     }
     public void StoppMotor()
     {
         ErMotorStartet = false;
         Console.WriteLine($"Motoren til {Brand} {Modell} er skrudd av.");
     }
                                   
     public void Kjør()
     {
         if (ErMotorStartet)
         {
             Kilometerstand += 100;
             Console.WriteLine($"{Brand} {Modell} har kjørt {Kilometerstand} km");
         }
         else
         {
             Console.WriteLine($"Motoren til {Brand} {Modell} er skrudd av. Skru den på for å kjøre");
         }
     }
                                   
     public void EndreFarge()
     {
         NewColor = "Svart";
                                   
         Console.WriteLine($"{this.Brand} {this.Modell} som hadde fargen {this.Color} har nå fått fargen {this.NewColor}");
     }
                                   
     public void VisInfo()
     {
         Console.WriteLine($"{this.Brand} {this.Modell} har {this.Color} farge og har kjørt {this.Kilometerstand} km.");
     }
 }
                                   
class Program
{
    static void Main(string[] args)
    {
        Bil bil = new Bil();
        Bil bil2 = new Bil();
                                           
        bil.Brand = "Volvo";
        bil.Modell = "V90";
        bil.Color = "Ukjent";
        bil.Kilometerstand = 0;
        bil.ErMotorStartet = false;
                                           
        bil2.Brand = "BMW";
        bil2.Modell = "X7 SUV";
        bil2.Color = "Ukjent";
        bil2.Kilometerstand = 2000;
        bil2.ErMotorStartet = false;
                                   
                                   
        bil.VisInfo();
        bil2.VisInfo();
        bil.Kjør();
        bil.StartMotor();
        bil2.StartMotor();
        bil.Kjør();
        bil2.Kjør();
        bil2.EndreFarge();
                                   
    }
}