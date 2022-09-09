using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    internal class Car
    {
        // Atribute
        public string brand;
        public string model;
        public float motorizare;
        public long sasiu;
        public string collor;
        public bool headupdisplay;

        // Constructori
        // Constructor implicit
        public Car()
        {
            brand = "BMW";
            sasiu = 223311;
        }
        // Constructor explicit partial
        public Car(string brand, long sasiu, bool headupdisplay)
        {
            this.brand = brand;
            this.sasiu = sasiu;
            this.headupdisplay = headupdisplay;
        }
        // Constructor explicit
        public Car(string brand, string model, int motorizare, long sasiu, string collor, bool headupdisplay)
        {
            this.brand = brand;
            this.model = model;
            this.motorizare = motorizare;
            this.sasiu = sasiu;
            this.collor = collor;
            this.headupdisplay = true;
        }
        // Functie
        public void writeToConsole()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Motorizare: " + motorizare);
            Console.WriteLine("Sasiu: " + sasiu);
            Console.WriteLine("Culoare: " + collor);
            Console.WriteLine("HeadUp Display: " + headupdisplay);
        }
    }
}
