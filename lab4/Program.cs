using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new HelloKitty(){
                Name="Tomas"
            };
            var cat1 = new HelloKitty(){
                Name="Garfield"
            };
            var cat2 = new HelloKitty(){
                Name="Tommy"
            };
            cat1.MakeNoise();
            cat2.MakeNoise();
            cat.MakeNoise();
        }
    }
    public class HelloKitty
    {
        public String Name { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine(Name + " says Meow!");
        }

    }
}
