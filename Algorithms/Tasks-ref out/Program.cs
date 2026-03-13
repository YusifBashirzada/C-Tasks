
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 31
            //int eded1;
            //int eded2;
            //Changevalue(out eded1, out eded2);
            //Console.WriteLine(eded1);
            //Console.WriteLine(eded2);

            // 32
            //Console.WriteLine("Bir eded daxil edin:");
            //int eded = Convert.ToInt32(Console.ReadLine());
            //Addition(ref eded);
            //Console.WriteLine("Netice: " + eded);

            // 33
            //int eded1;
            //int eded2;
            //int qaliq;
            //int netice;
            //Checkdivide(out eded1, out eded2, out qaliq, out netice);
            //Console.WriteLine("Qaliq: " + qaliq);
            //Console.WriteLine("Netice: " + netice);

            // 34
            //int eded1;
            //int eded2;
            //int eded3;
            //FindMinMax(out eded1, out eded2, out eded3, out int min, out int max);

            // 35
            //Console.WriteLine("Bali daxil edin:");
            //int bal = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Artimi daxil edin:");
            //int artim = Convert.ToInt32(Console.ReadLine());
            //int netice;
            //Increasescore(ref bal, ref artim, out netice);
            //Console.WriteLine("Netice: " + netice);

            // 36
            //string ad;
            //int yas;
            //Checkage(out ad, out yas);
            //Console.WriteLine(ad);

            // 37
            //int[] arr = [120, 250, 300, 400];
            //Discount();

            // 38
            //string ad;
            //string soyad;
            //int yas;
            //string mail;
            //string sifre;
            //string istifadeciadi;
            //DateTime now = DateTime.Now;
            //string text = now.ToString("ddMMyyyyHHmmss");
            //Register(out ad, out soyad, out yas, out mail, out sifre, out istifadeciadi, ref text);
            //Console.WriteLine("Ugurlu Qeydiyyat");
            //Console.WriteLine("Giris ede bilersiniz");
            //Console.WriteLine(istifadeciadi + text);
        }

        // 31_______________________
        //static void Changevalue(out int num1, out int num2)
        //{
        //    num1 = 1;
        //    num2 = 2;
        //    //num1 = Convert.ToInt32(Console.ReadLine());
        //    //num2 = Convert.ToInt32(Console.ReadLine());
        //    num1 = num2;
        //    num2 = num1;
        //}

        // 32_______________________

        //static void Addition(ref int num)
        //{
        //    num += 10;
        //} 

        // 33_______________________
        //static void Checkdivide(out int num1, out int num2, out int residue, out int result)
        //{
        //    Console.WriteLine("Ilk ededi daxil edin:");
        //    num1  = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Ikinci ededi daxil edin:");
        //    num2 = Convert.ToInt32(Console.ReadLine());
        //    residue = num1 % num2;
        //    result = num1 / num2;
        //}

        // 34_______________________
        //static void FindMinMax(out int num1,out int num2,out int num3, out int min, out int max)
        //{
        //    Console.WriteLine("Ilk ededi daxil edin:");
        //    num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Ikinci ededi daxil edin:");
        //    num2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Ucuncu ededi daxil edin:");
        //    num3 = Convert.ToInt32(Console.ReadLine());
        //    if (num1 > num2 && num2 < num3)
        //    {
        //        min = num2;
        //    }
        //}

        // 35_______________________
        //static void Increasescore(ref int score, ref int increase, out int result)
        //{
        //    result = score + increase;
        //}

        // 36_______________________ Yarimciq
        //static void Checkage(out string name, out int age)
        //{
        //    Console.WriteLine("Adi daxil edin:");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Yasi daxil edin: ");
        //}

        // 37_______________________
        //static void Discount(ref int[] pricesarr)
        //{

        //}

        // 38_______________________
        //static void Register(out string name, out string surname, out int age, out string email, out string password, out string username, ref string date)
        //{
        //    Console.WriteLine("Ad daxil edin: ");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Soyad daxil edin: ");
        //    surname = Console.ReadLine();
        //    Console.WriteLine("Yas daxil edin: ");
        //    age = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Email daxil edin: ");
        //    email = Console.ReadLine();
        //    Console.WriteLine("Sifre daxil edin: ");
        //    password = Console.ReadLine();
        //    Console.WriteLine("Istifadeci adi daxil edin: ");
        //    username = Console.ReadLine();
        //    username.Concat(date);
        //}
    }
}
