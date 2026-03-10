using System.Globalization;

// 25_____________________

//Console.WriteLine("1 ve 100 araliginda bir eded daxil edin:");
//int eded = Convert.ToInt32(Console.ReadLine());

//if (1 < eded && eded < 100)
//{
//    int netice = (int)Math.Pow(eded, 3);
//    Console.WriteLine("Ededin kubu: " + netice);
//}
//else Console.WriteLine("Daxil etdiyiniz eded 1 ve 100 araliginda deyil");

// 26_______________________ Yarimciq

//Console.WriteLine("Adinizi Daxil Edin:");
//string ad = Console.ReadLine();
//Console.WriteLine("Soyadinizi Daxil Edin:");
//string soyad = Console.ReadLine();

//string netice = (string)ad.Concat(soyad);

//Console.WriteLine(netice);

// 27_______________________

//Console.WriteLine("Bir Soz Daxil Edin:");
//string soz = Console.ReadLine();
//int sozuzunlugu = soz.Length;

//Console.WriteLine(soz + " - " + sozuzunlugu + " herf");

// 28_______________________ Yarimciq

//string tapilmalimeyve = "alma";


//Console.WriteLine("Oyunun Qaydalari:");
//Console.WriteLine("Bir Meyve adi var onu tapmalisiniz");
//Console.WriteLine("3 sansiniz var");
//Console.WriteLine("3 sans ile tapsaz qazanirsiz, eks halda meglub olursuz");
//Console.WriteLine("Baslayaq");
//Console.WriteLine("Hansi meyvedir bu? Meyvenin adini daxil edin:");
//string texminedilen = Console.ReadLine().ToLower();
//int count = 0;

//if(count <= 3)
//{
//    if (texminedilen == tapilmalimeyve)
//    {
//        Console.WriteLine("Siz qazandiniz tebrikler");
//    }
//    else
//    {
//        texminedilen = Console.ReadLine().ToLower();
//        count++;
//    }
//}
//else Console.WriteLine("Siz meglub oldunuz");



// 29_______________________

//for (int i = 0; i < 100; i++)
//{
//    if (i % 7 == 0 && i % 10 == 7)
//    {
//        string stri = Convert.ToString(i);
//        stri = "DIZZ";
//    }
//    Console.Write(i  + ",");
//}

// 30_______________________

int [] arr = [10, 12, 22, 10, 32, 22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15];
int count = 0;

for(int i = 0;  i < arr.Length; i++)
{
    if (arr[i] != arr[i - 1])
    {
        int ferqli = arr[i];
        count++;
    }
    Console.WriteLine(count);
}

// 31_______________________


// 32_______________________


// 33_______________________