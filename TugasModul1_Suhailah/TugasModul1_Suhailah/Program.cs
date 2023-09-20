using System;

namespace TugasModul1_Suhailah
{
    class Processor
    {
        public string Merk;
        public string Tipe;

        public Processor(string merk, string tipe)
        {
            this.Merk = merk;
            this.Tipe = tipe;
        }
    }

    class Intel : Processor
    {
        public Intel(string tipe) : base ("Intel", tipe)
        {
            
        }
    }

    class Corei3 : Intel
    {
        public Corei3() : base ("Core i3")
        {

        }
    }

    class Corei5 : Intel
    {
        public Corei5() : base("Core i5")
        {

        }
    }

    class Corei7 : Intel
    {
        public Corei7() : base("Core i7")
        {

        }
    }

    class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe)
        {

        }
    }

    class Ryzen : AMD
    {
        public Ryzen() : base("RAYZEN")
        {

        }
    }

    class Athlon : AMD
    {
        public Athlon() : base("ATHLON")
        {

        }
    }

    class VGA
    {
        public string Merk;

        public VGA(string merk)
        {
            this.Merk = merk;
        }
    }

    class Nvidia : VGA
    {
        public Nvidia() : base("Nvidia")
        {

        }
    }

    class AMD_VGA : VGA
    {
        public AMD_VGA() : base("AMD")
        {

        }
    }

    class Laptop
    {
        public string Merk;
        public string Tipe;
        public VGA Vga;
        public Processor Processor;

        public Laptop(string merk, string tipe, VGA vga, Processor processor)
        {
            this.Merk = merk;
            this.Tipe = tipe;
            this.Vga = vga;
            this.Processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop " + Merk + " " + Tipe + " Menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop " + Merk + " " + Tipe + " Mati");
        }
    }

    class Asus : Laptop
    {
        public Asus(string tipe, VGA vga, Processor processor) : base ("ASUS", tipe, vga, processor)
        {

        }
    }

    class ROG : Asus
    {
        public ROG(VGA vga, Processor processor) : base ("ROG", vga, processor)
        {

        }
    }

    class Vivobook : Asus
    {
        public Vivobook(VGA vga, Processor processor) : base("Vivobook", vga, processor)
        {

        }

        public void Ngoding()
        {
            Console.WriteLine("Ctak, Ctak, Ctak, error lagi!!");
        }
    }

    class Acer : Laptop
    {
        public Acer(string tipe, VGA vga, Processor processor) : base("Acer", tipe, vga, processor)
        {

        }
    }

    class Swift : Acer
    {
        public Swift(VGA vga, Processor processor) : base("Swift", vga, processor)
        {

        }
    }

    class Predator : Acer
    {
        public Predator(VGA vga, Processor processor) : base("Predator", vga, processor)
        {

        }

        public void BermainGame()
        {
            Console.WriteLine("Laptop " + Merk + " " + Tipe + " Sedang Memainkan Game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo(string tipe, VGA vga, Processor processor) : base("Lenovo", tipe, vga, processor)
        {

        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad(VGA vga, Processor processor) : base("IdeaPad", vga, processor)
        {

        }
    }

    class Legion : Lenovo
    {
        public Legion(VGA vga, Processor processor) : base("Legion", vga, processor)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook(new Nvidia(), new Corei5());
            IdeaPad laptop2 = new IdeaPad(new AMD_VGA(), new Ryzen());
            Predator predator = new Predator(new AMD_VGA(), new Corei7());

            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            // laptop1.Ngoding(); //Ini Error

            Console.WriteLine("SPESIFIKASI LAPTOP1");
            Console.WriteLine("Merk VGA : " + laptop1.Vga.Merk);
            Console.WriteLine("Merk Processor : " + laptop1.Processor.Merk);
            Console.WriteLine("Tipe Processor : " + laptop1.Processor.Tipe);

            predator.BermainGame();

            Acer acer = new Predator(new Nvidia(), new Corei7());

            // acer.BermainGame(); //Ini Error
           
        }
    }
}