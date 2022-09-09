namespace CarApp
{
    public class Program
    {
        public static void Main (string[]args)
        {
            Car car1 = new Car();
            Console.WriteLine(car1.brand);
            car1.sasiu = 223311;
            Console.WriteLine(car1.sasiu);
           
            Car car2 = new Car("Audi", 222111, true);
            car2.model = "A3";
            car2.motorizare = 2000;
            car2.collor = "Rosu";
            car2.writeToConsole();

            Car car3 = new Car("Mercedes", "S-Klasse", 2200, 13245, "Negru", true);
            car3.writeToConsole();

            Car car4 = new Car("Volkswagen", 278911, false);
            car4.writeToConsole();

            Car car5 = new Car("Toyota", "RaV", 1800, 888192, "Verde", true);
            car5.writeToConsole();

            Car car6 = new Car();
            car6.brand = "Lamborghini";
            Console.WriteLine(car6.brand);
            car6.model = "Huracan";
            Console.WriteLine(car6.model);
            car6.sasiu = 888111;
            Console.WriteLine(car6.sasiu);
            car6.motorizare = 5000;
            Console.WriteLine(car6.motorizare);
            car6.collor = "Mov";
            Console.WriteLine(car6.collor);
            car6.headupdisplay = true;
            Console.WriteLine(car6.headupdisplay);

            Car car7 = new Car("Hyundai", 819021, true);
            car7.model = "Tucson";
            car7.motorizare = 1600;
            car7.collor = "Alb";
            car7.writeToConsole();

            Car car8 = new Car("Range Rover", "Evoque", 3200, 777123, "Gri", true);
            car8.writeToConsole();

            Car car9 = new Car("Dacia", "Logan", 1000, 888000, "Alb", false);
            car9.writeToConsole();

            Car car10 = new Car("Renault", 810023, false);
            car10.model = "Eclipse";
            car10.motorizare = 1200;
            car10.collor = "Galben";
            car10.writeToConsole();




            
        }
    }
}
