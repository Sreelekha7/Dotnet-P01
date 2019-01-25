using System;

namespace Dotnet_P01
{
    class Program
    {
        public static double kglbConversion(double kgcount, double kgcnvr)
        {
            return kgcount*kgcnvr;
        }

        public static double lbkgConversion(double poundcount, double poundcnvr)
        {
            return poundcount*poundcnvr;
        }

        static void Main(string[] args)
        {
            var name= "";
            var ch=0;
            var kgcnvr=2.204;
            var poundcnvr=0.453;
            var kgcount=0.0;
            var poundcount=0.0;
            var kgsTotal=0.0;
            var lbsTotal=0.0;
            var d='q';
            var def="";
            var quit = false;
        

            while(name=="")
            {
            Console.WriteLine($"Welcome to Weight conversion App");
            Console.WriteLine($"Enter your name: ");
            name=Console.ReadLine();
            }
            do{
            Console.WriteLine($"Hello {name}");

            Console.WriteLine($"Enter any key to continue or 'q' to exit");
            var ab = Console.ReadLine();
            d = Convert.ToChar(ab);
            if(d != 'q')
            {
                
            Console.WriteLine($"Please select your choice");
            Console.WriteLine($"Enter 1 for kgs to lbs conversion \n Enter 2 for lbs to kgs conversion");
            var a=Console.ReadLine();
            ch=Convert.ToInt16(a);

            switch(ch)
            {
                case 1: Console.WriteLine($"Enter your weight in kgs");
                        var b=Console.ReadLine();
                        kgcount=Convert.ToInt32(b);
                        var r=Program.kglbConversion(kgcount,kgcnvr);
                        lbsTotal=r;
                        Console.WriteLine($"Your weight is {lbsTotal}lbs");
                        break;
                case 2: Console.WriteLine($"Enter your weight in lbs");
                        var c=Console.ReadLine();
                        poundcount=Convert.ToInt32(c);
                        var s=Program.lbkgConversion(poundcount,poundcnvr);
                        kgsTotal=s;
                        Console.WriteLine($"Your weight is {kgsTotal}kgs");
                        break;
                default: break;
            }


            }
            
            
                Console.WriteLine("Do you want to convert it again yes or no");
                def = Console.ReadLine();
                if (def=="no") {
                    quit = true;
                    Console.WriteLine($"Thank you");
                }
        }
        while(quit==false);
            
        }
    }
}