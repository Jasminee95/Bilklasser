// See https://aka.ms/new-console-template for more information

namespace bilklasser;
                                   
 class Bil
 {
     public string Brand;
     public string Modell;
     public string Color;
     public int Kilometerstand;
     public bool ErMotorStartet;

     public Bil(string brand, string modell)
     {
         Brand = brand;
         Modell = modell;
         Color = "Ukjent";
         Kilometerstand = 0;
         ErMotorStartet = false;
     }

     public void StartMotor()
     {
         if (!ErMotorStartet)
         {
             ErMotorStartet = true;
             Console.WriteLine($"Motoren til {Brand} {Modell} er startet.");

         }
     }

     public void StoppMotor()
     {
         ErMotorStartet = false;
         Console.WriteLine($"Motoren til {Brand} {Modell} er skrudd av.");
     }
                                   
     public void Kjør(int distance)
     {
         if (ErMotorStartet)
         {
             Kilometerstand += distance;
             Console.WriteLine($"{Brand} {Modell} har kjørt {distance} km. Total kilometeravstand {Kilometerstand} km");
         }
         else
         {
             Console.WriteLine($"Motoren til {Brand} {Modell} er skrudd av. Skru den på for å kjøre");
         }
     }
                                   
     public void EndreFarge(string newColor)
     {
         string oldColor = Color;
         Color = newColor;
         Console.WriteLine($"{this.Brand} {this.Modell} som hadde fargen {this.Color} har nå fått fargen {newColor}");
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
        Bil Volvo = new Bil("Volvo", "V90");
        Bil BMW = new Bil("BMW", "X7 SUV");
        
        Volvo.VisInfo();
        BMW.VisInfo();
        Volvo.Kjør(150);
        Volvo.StartMotor();
        BMW.StartMotor();
        Volvo.Kjør(150);
        BMW.Kjør(36);
        BMW.EndreFarge("Svart");
        Volvo.EndreFarge("Red");
        Volvo.VisInfo();
        BMW.VisInfo();

        Volvo.StoppMotor();

    }
}