using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    //PARENT CLASS
    public class Processor
    {
        public string merk, tipe;
    }


    //CHILDCLASS DARI PROCESSOR
    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    
    //CHILDCLASS DARI PROCESSOR
    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    //CHILDCLASS DARI INTEL
    public class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Core i3";
        }
    }

    //CHILDCLASS DARI INTEL
    public class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core i5";
        }
    }

    //CHILDCLASS DARI INTEL
    public class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core i7";
        }
    }

    //CHILDCLASS DARI AMD
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "Ryzen";
        }
    }

    //CHILDCLASS DARI AMD
    public class ATHLON : AMD
    {
        public ATHLON()
        {
            base.tipe = "ATHLON";
        }
    }

    //PARENT CLASS
    public class VGA
    {
        public string merk;
    }

    //CHILDCLASS DARI VGA
    public class Nvidia : VGA
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    //CHILDCLASS DARI VGA
    public class amd : VGA
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }


    //PARENT CLASS
    public class Laptop
    {
        public string merk, tipe;
        public VGA vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
       
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    //CHILDCLASS DARI LAPTOP
    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }

    //CHILDCLASS DARI LAPTOP
    public class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    //CHILDCLASS DARI LAPTOP
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }

    //CHILDCLASS DARI ASUS
    public class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    //CHILDCLASS DARI ASUS
    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak ctak ctak, error lagii!!!");
        }
    }

    //CHILDCLASS DARI ACER    
    public class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    //CHILDCLASS DARI ACER
    public class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game.");
        }
    }

    //CHILDCLASS DARI LENOVO    
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    //CHILDCLASS DARI LENOVO
    public class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
              //SOAL 1
                Laptop laptop2 = new IdeaPad();
                laptop2.vga = new amd();
                laptop2.processor = new Ryzen();

                laptop2.LaptopDinyalakan();
                laptop2.LaptopDimatikan();

              //SOAL 2                
                Laptop laptop1 = new Vivobook();
                laptop1.vga = new Nvidia();
                laptop1.processor = new Corei5();
                //laptop1.Ngoding();

                //Vivobook soal2 = new Vivobook();
                //soal2.vga = new Nvidia();
                //soal2.processor = new Ryzen();

                //soal2.Ngoding();

              //SOAL 3
                Console.WriteLine($"Merk VGA: {laptop1.vga.merk}");
                Console.WriteLine($"Merk Prosesor: {laptop1.processor.merk}");
                Console.WriteLine($"Tipe Prosesor: {laptop1.processor.tipe}");

              //SOAL 4
                Predator predator = new Predator();
                predator.vga = new Nvidia();
                predator.processor = new Ryzen();
                predator.BermainGame();

              //SOAL 5
                ACER acer = new Predator();
                //acer.BermainGame();


        }
    }


