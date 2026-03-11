using System.Text;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 _________
            // Choosemaximum(52, 32);

            // 2 _________
            // Divideto2(39);

            // 3 _________
            //Checkeded100(99);

            // 4 _________
            //Checkyas(18);

            // 5 _________
            //Checksign(20);

            // 6 _________
            //Checkweekday(5);

            // 7 _________
            //Cubeofnumber(7);

            // 8 _________
            //Checkmonthday(12);

            // 14 _________
            //Divideto3(20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30);

            // 15 _________
            //Findmaxsumavg(20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30);

            // 16 _________
            //Checkprime(121);

            // 17 _________
            //divideto6(23, 60, 12, 43, 56, 100, 23, 43, 21, 36, 72);

            // 18 _________
            //Calculator(2, 3, '+');

            // 19 _________
            //Discount20(100.0, 1300.50, 259.99, 430.30, 168.99, 320.0);

            // 21 _________
            //Triangle(22, 33, 33);

            // 22 _________
            //Game();

            // 23 _________
            //Rectangle(3, 5);

            // 24 _________
            //Polindrome(23);

            // 25 _________
            //Cubeof100(5);

            // 26 _________
            //Concatfullname("Yusif", "Besirzade");

            // 27 _________
            //Wordlength("Yusif");

            // 28 _________
            //Findnamegame();

            // 29 _________
            //DIZZgame();

            // 30 _________
            //Differentnumbers(10, 12, 22, 10, 32, 22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15);

        }

        // 1 __________________

        //int ilkeded = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("ilk eded:" + " " + ilkeded);
        //int ikincieded = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("ikinci eded:" + " " + ikincieded);
        //if (ilkeded > ikincieded)
        //{
        //    Console.WriteLine("En boyuk eded:" + " " + ilkeded);
        //}
        //else
        //{
        //    Console.WriteLine("En boyuk eded:" + " " + ikincieded);
        //}


        //static void Choosemaximum(int ilkeded, int ikincieded)
        //{
        //    if (ilkeded > ikincieded)
        //    {
        //        Console.WriteLine("En boyuk eded:" + " " + ilkeded);
        //    }
        //    else
        //    {
        //        Console.WriteLine("En boyuk eded:" + " " + ikincieded);
        //    }
        //}

        // 2 __________________

        //int verilenEded = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Verilen Ededimiz:" + " " + verilenEded);
        //if (verilenEded % 2 == 0)
        //{
        //    Console.WriteLine("Eded 2-ye qaliqsiz Bolunur!");
        //}
        //else
        //{
        //    Console.WriteLine("Eded 2-ye qaliqsiz Bolunmur!");
        //}

        //static void Divideto2(int verilenEded) {
        //    if (verilenEded % 2 == 0)
        //    {
        //        Console.WriteLine("Eded 2-ye qaliqsiz Bolunur!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Eded 2-ye qaliqsiz Bolunmur!");
        //    }
        //}

        // 3 ___________________

        //int eded = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Daxil edilen eded:" + " " + eded);
        //if (eded >= 100)
        //{
        //    Console.WriteLine("Boyuk");
        //}
        //else
        //{
        //    Console.WriteLine("Kicik");
        //}

        //static void Checkeded100(int eded)
        //{
        //    if (eded >= 100)
        //    {
        //        Console.WriteLine("Boyuk");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Kicik");
        //    }
        //}

        // 4 ___________________

        //int yas = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Daxil edilen yas:" + " " + yas);
        //if(yas > 18)
        //{
        //    Console.WriteLine("Adult");
        //}
        //else
        //{
        //    Console.WriteLine("Child");
        //}

        //static void Checkyas(int yas)
        //{
        //    if (yas > 18)
        //    {
        //        Console.WriteLine("Adult");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Child");
        //    }
        //}

        // 5 ____________________

        //int ededyoxla = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Daxil edilen eded:" + ededyoxla);
        //if(ededyoxla == 0)
        //{
        //    Console.WriteLine("0 ne musbetdir, ne de menfi");
        //}
        //else if ( ededyoxla > 0 )
        //{
        //    Console.WriteLine("Eded Musbetdir");
        //}
        //else
        //{
        //    Console.WriteLine("Eded Menfidir");
        //}

        //static void Checksign(int ededyoxla)
        //{
        //    if (ededyoxla == 0)
        //    {
        //        Console.WriteLine("0 ne musbetdir, ne de menfi");
        //    }
        //    else if (ededyoxla > 0)
        //    {
        //        Console.WriteLine("Eded Musbetdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Eded Menfidir");
        //    }
        //}

        // 6 _____________________

        //int hefteningunu = Convert.ToInt32(Console.ReadLine());
        //switch (hefteningunu)
        //{
        //    case 1:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Tuesday");
        //        break;
        //    case 3:
        //        Console.WriteLine("Wednesday");
        //        break;
        //    case 4:
        //        Console.WriteLine("Thursday");
        //        break;
        //    case 5:
        //        Console.WriteLine("Friday");
        //        break;
        //    case 6:
        //        Console.WriteLine("Saturday");
        //        break;
        //    case 7:
        //        Console.WriteLine("Sunday");
        //        break;
        //    default:
        //        Console.WriteLine("Gunu duzgun daxil edin");
        //        break;
        //}

        //static void Checkweekday(int hefteningunu)
        //{
        //    switch (hefteningunu)
        //    {
        //        case 1:
        //            Console.WriteLine("Monday");
        //            break;
        //        case 2:
        //            Console.WriteLine("Tuesday");
        //            break;
        //        case 3:
        //            Console.WriteLine("Wednesday");
        //            break;
        //        case 4:
        //            Console.WriteLine("Thursday");
        //            break;
        //        case 5:
        //            Console.WriteLine("Friday");
        //            break;
        //        case 6:
        //            Console.WriteLine("Saturday");
        //            break;
        //        case 7:
        //            Console.WriteLine("Sunday");
        //            break;
        //        default:
        //            Console.WriteLine("Gunu duzgun daxil edin");
        //            break;
        //    }
        //}

        // 7 _____________________

        //int hesablanacaqeded = Convert.ToInt32(Console.ReadLine());
        //int kubhesabla = hesablanacaqeded * hesablanacaqeded * hesablanacaqeded;
        //Console.WriteLine("Ededin Kubu:" + kubhesabla);

        //static void Cubeofnumber(int hesablanacaqeded)
        //{
        //    int kubhesabla = hesablanacaqeded * hesablanacaqeded * hesablanacaqeded;
        //    Console.WriteLine("Ededin Kubu:" + kubhesabla);
        //}


        // 8 _____________________

        //int aygunleri = Convert.ToInt32(Console.ReadLine());
        //switch(aygunleri)
        //{
        //    case 1:
        //        Console.WriteLine("Yanvar 31 gundur");
        //        break;
        //    case 2:
        //        Console.WriteLine("Fevral 28 gundur");
        //        break;
        //    case 3:
        //        Console.WriteLine("Mart 31 gundur");
        //        break;
        //    case 4:
        //        Console.WriteLine("Aprel 30 gundur");
        //        break;
        //    case 5:
        //        Console.WriteLine("May 31 gundur");
        //        break;
        //    case 6:
        //        Console.WriteLine("Iyun 30 gundur");
        //        break;
        //    case 7:
        //        Console.WriteLine("Iyul 31 gundur");
        //        break;
        //    case 8:
        //        Console.WriteLine("Avqust 31 gundur");
        //        break;
        //    case 9:
        //        Console.WriteLine("Sentyabr 30 gundur");
        //        break;
        //    case 10:
        //        Console.WriteLine("Oktyabr 31 gundur");
        //        break;
        //    case 11:
        //        Console.WriteLine("Noyabr 30 gundur");
        //        break;
        //    case 12:
        //        Console.WriteLine("Dekabr 31 gundur");
        //        break;
        //}

        //static void Checkmonthday(int aygunleri)
        //{
        //    switch (aygunleri)
        //    {
        //        case 1:
        //            Console.WriteLine("Yanvar 31 gundur");
        //            break;
        //        case 2:
        //            Console.WriteLine("Fevral 28 gundur");
        //            break;
        //        case 3:
        //            Console.WriteLine("Mart 31 gundur");
        //            break;
        //        case 4:
        //            Console.WriteLine("Aprel 30 gundur");
        //            break;
        //        case 5:
        //            Console.WriteLine("May 31 gundur");
        //            break;
        //        case 6:
        //            Console.WriteLine("Iyun 30 gundur");
        //            break;
        //        case 7:
        //            Console.WriteLine("Iyul 31 gundur");
        //            break;
        //        case 8:
        //            Console.WriteLine("Avqust 31 gundur");
        //            break;
        //        case 9:
        //            Console.WriteLine("Sentyabr 30 gundur");
        //            break;
        //        case 10:
        //            Console.WriteLine("Oktyabr 31 gundur");
        //            break;
        //        case 11:
        //            Console.WriteLine("Noyabr 30 gundur");
        //            break;
        //        case 12:
        //            Console.WriteLine("Dekabr 31 gundur");
        //            break;
        //    }
        //}

        // 14 _____________________

        //int[] ededler = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
        //for (int i = 0; i < ededler.Length; i++)
        //{
        //    if (ededler[i] % 3 == 0)
        //    {
        //        Console.WriteLine(ededler[i]);
        //    }
        //}

        //static void Divideto3(params int[] ededler)
        //{
        //    for (int i = 0; i < ededler.Length; i++)
        //    {
        //        if (ededler[i] % 3 == 0)
        //        {
        //            Console.WriteLine(ededler[i]);
        //        }
        //    }
        //}

        // 15 _____________________

        //int[] ededler = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
        //Array.Sort(ededler);
        //Console.WriteLine("Minimum:" + " " + ededler[0]);
        //Console.WriteLine("Maximum:" + " " + ededler[ededler.Length - 1]);
        //int cem = 0;
        //for (int i = 0; i<ededler.Length; i++)
        //{
        //    cem+=ededler[i];
        //}
        //int edediorta = cem / ededler.Length;
        //Console.WriteLine("Ededi orta:" + " " + edediorta);

        //static void Findmaxsumavg(params int[] ededler)
        //{
        //    Array.Sort(ededler);
        //    Console.WriteLine("Minimum:" + " " + ededler[0]);
        //    Console.WriteLine("Maximum:" + " " + ededler[ededler.Length - 1]);
        //    int cem = 0;
        //    for (int i = 0; i < ededler.Length; i++)
        //    {
        //        cem += ededler[i];
        //    }
        //    int edediorta = cem / ededler.Length;
        //    Console.WriteLine("Ededi orta:" + " " + edediorta);
        //}


        // 16 _____________________

        //int eded = Convert.ToInt32(Console.ReadLine());
        //bool isPrime = false;
        //for (int i = 2; i < eded; i++)
        //{
        //    if (eded % i == 0) { isPrime = false; break; }
        //    else isPrime = true;
        //}

        //if (!isPrime) Console.WriteLine("Prime Deyil");
        //else Console.WriteLine("Primedir");

        //static void Checkprime(int eded)
        //{
        //    bool isPrime = false;
        //    for (int i = 2; i < eded; i++)
        //    {
        //        if (eded % i == 0) { isPrime = false; break; }
        //        else isPrime = true;
        //    }

        //    if (!isPrime) Console.WriteLine("Prime Deyil");
        //    else Console.WriteLine("Primedir");
        //}


        // 17 _____________________

        //int[] arr = [23, 60, 12, 43, 56, 100, 23, 43, 21, 36, 72];
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (arr[i]%6==0)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}

        //static void divideto6(params int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] % 6 == 0)
        //        {
        //            Console.WriteLine(arr[i]);
        //        }
        //    }
        //}

        // 18 _____________________

        //Console.WriteLine("ilk ededi daxil edin:");
        //int a = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("ikinci ededi daxil edin:");
        //int b = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Operate Daxil Edin:");
        //char op = Convert.ToChar(Console.ReadLine());

        //    switch (op)
        //    {
        //        case '+':
        //            Console.WriteLine(a + b);
        //            break;
        //        case '-':
        //            Console.WriteLine(a - b);
        //            break;
        //        case '*':
        //            Console.WriteLine(a* b);
        //            break;
        //        case '/':
        //            if(b == 0)
        //            {
        //                Console.WriteLine("0 - a bolme yoxdur!");
        //                break;
        //            }
        //Console.WriteLine(a / b);

        //            break;
        //        case '%':
        //            Console.WriteLine(a % b);
        //            break;
        //        case '^':
        //            Console.WriteLine(Math.Pow(a, b));
        //            break;
        //    }

        //static void calculator(int a, int b, char op)
        //{

        //    switch (op)
        //    {
        //        case '+':
        //            Console.WriteLine(a + b);
        //            break;
        //        case '-':
        //            Console.WriteLine(a - b);
        //            break;
        //        case '*':
        //            Console.WriteLine(a * b);
        //            break;
        //        case '/':
        //            if (b == 0)
        //            {
        //                Console.WriteLine("0 - a bolme yoxdur!");
        //                break;
        //            }
        //            Console.WriteLine(a / b);

        //            break;
        //        case '%':
        //            Console.WriteLine(a % b);
        //            break;
        //        case '^':
        //            Console.WriteLine(Math.Pow(a, b));
        //            break;
        //    }
        //}

        // 19 _____________________

        //double[] productsprice = [100.0, 1300.50, 259.99, 430.30, 168.99, 320.0];
        //double discount = 0.2;
        //for (int i = 0; i < productsprice.Length; i++)
        //{
        //    double newprice = productsprice[i] - (productsprice[i] * discount);
        //    Console.WriteLine(newprice);
        //}

        //static void Discount20(params double[] productsprice)
        //{
        //    double discount = 0.2;
        //    for (int i = 0; i < productsprice.Length; i++)
        //    {
        //        double newprice = productsprice[i] - (productsprice[i] * discount);
        //        Console.WriteLine(newprice);
        //    }
        //}

        // 20 _____________________

        //int[] isciyasi = [23, 34, 19, 65, 40, 66, 29, 35, 67, 64, 60, 32, 57];
        //for (int i = 0; i < isciyasi.Length; i++)
        //{
        //    if (isciyasi[i] >= 65)
        //    {
        //        Console.WriteLine(isciyasi[i] + " " + "Teqaude Ayrildiniz");
        //    }
        //}

        // 21 _____________________

        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());
        //int kvadratcem = (a * a) + (b * b);
        //if (c*c == kvadratcem)
        //{
        //    Console.WriteLine("Duzbucaqli Ucbucaqdir");
        //}
        //else if (a == b && a == c && b == c)
        //{
        //    Console.WriteLine("Beraberterefli Ucbucaqdir");
        //}
        //else if (a == b || a == c || b == c)
        //{
        //    Console.WriteLine("Beraberyanli Ucbucaqdir");
        //}
        //else
        //{
        //    Console.WriteLine("Muxtelifterefli Ucbucaqdir");
        //}

        //static void Triangle(int a, int b, int c)
        //{
        //    int kvadratcem = (a * a) + (b * b);
        //    if (c * c == kvadratcem)
        //    {
        //        Console.WriteLine("Duzbucaqli Ucbucaqdir");
        //    }
        //    else if (a == b && a == c && b == c)
        //    {
        //        Console.WriteLine("Beraberterefli Ucbucaqdir");
        //    }
        //    else if (a == b || a == c || b == c)
        //    {
        //        Console.WriteLine("Beraberyanli Ucbucaqdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Muxtelifterefli Ucbucaqdir");
        //    }
        //}

        // 22 _____________________

        //for (int i = 0; i < 100; i++)
        //{
        //    int teyinolunmus = 34;
        //    Console.WriteLine(i);
        //    for (int say = 1; say <= 5; say++)
        //    {
        //        int eded = Convert.ToInt32(Console.ReadLine());
        //        if (eded == teyinolunmus)
        //        {
        //            Console.WriteLine("You Won");
        //            break;
        //        }
        //        else if(say == 5)
        //        {
        //            Console.WriteLine("Game Over");
        //        }
        //    }  
        //    break;
        //}

        //static void Game()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        int teyinolunmus = 34;
        //        Console.WriteLine(i);
        //        for (int say = 1; say <= 5; say++)
        //        {
        //            int eded = Convert.ToInt32(Console.ReadLine());
        //            if (eded == teyinolunmus)
        //            {
        //                Console.WriteLine("You Won");
        //                break;
        //            }
        //            else if (say == 5)
        //            {
        //                Console.WriteLine("Game Over");
        //            }
        //        }
        //        break;
        //    }
        //}

        // 23 _____________________

        //Console.WriteLine("Kavdratda a = b olur");
        //Console.WriteLine("Duzbucaqli dorbucaqda a != b olur");
        //Console.WriteLine("Terefleri Daxil Edin:");
        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int sahe = 1;

        //if (a == b)
        //{
        //    sahe = a * a;
        //    Console.WriteLine("Kvadratin sahesi:" + sahe);
        //}
        //else
        //{
        //    sahe = 2 * (a + b);
        //    Console.WriteLine("Duzbucaqli Dordbucaq Sahesi:" + sahe);
        //}

        //Console.WriteLine("Duzbucaqli Ucbucagin Tereflerini Daxil Edin:");
        //int c = Convert.ToInt32(Console.ReadLine());
        //int d = Convert.ToInt32(Console.ReadLine());
        //int e = Convert.ToInt32(Console.ReadLine());
        //int ucbucaqsahe = (c * d)/5;
        //Console.WriteLine("Ucbucagin Sahesi:" + " " + ucbucaqsahe);

        //static void Rectangle(int a, int b)
        //{
        //    int sahe = 1;

        //    if (a == b)
        //    {
        //        sahe = a * a;
        //        Console.WriteLine("Kvadratin sahesi:" + sahe);
        //    }
        //    else
        //    {
        //        sahe = 2 * (a + b);
        //        Console.WriteLine("Duzbucaqli Dordbucaq Sahesi:" + sahe);
        //    }

        //    Console.WriteLine("Duzbucaqli Ucbucagin Tereflerini Daxil Edin:");
        //    int c = Convert.ToInt32(Console.ReadLine());
        //    int d = Convert.ToInt32(Console.ReadLine());
        //    int e = Convert.ToInt32(Console.ReadLine());
        //    int ucbucaqsahe = (c * d) / 5;
        //    Console.WriteLine("Ucbucagin Sahesi:" + " " + ucbucaqsahe);
        //}

        // 24 _____________________

        //int eded = Convert.ToInt32(Console.ReadLine());
        //int original = eded;
        //int tersinecevrilmis = 0;
        //while (eded > 0)
        //{
        //    int reqem = eded % 10;
        //    tersinecevrilmis = tersinecevrilmis * 10 + reqem;
        //    eded = eded / 10;
        //}

        //if (original == tersinecevrilmis)
        //{
        //    Console.WriteLine("Polindromdur");
        //}
        //else
        //{
        //    Console.WriteLine("Polindrom Deyil");
        //}

        //static void Polindrome(int eded)
        //{
        //    int original = eded;
        //    int tersinecevrilmis = 0;
        //    while (eded > 0)
        //    {
        //        int reqem = eded % 10;
        //        tersinecevrilmis = tersinecevrilmis * 10 + reqem;
        //        eded = eded / 10;
        //    }

        //    if (original == tersinecevrilmis)
        //    {
        //        Console.WriteLine("Polindromdur");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Polindrom Deyil");
        //    }
        //}

        // 25_____________________

        //Console.WriteLine("1 ve 100 araliginda bir eded daxil edin:");
        //int eded = Convert.ToInt32(Console.ReadLine());

        //if (1 < eded && eded < 100)
        //{
        //    int netice = (int)Math.Pow(eded, 3);
        //    Console.WriteLine("Ededin kubu: " + netice);
        //}
        //else Console.WriteLine("Daxil etdiyiniz eded 1 ve 100 araliginda deyil");

        //static void Cubeof100(int eded)
        //{
        //    if (1 < eded && eded < 100)
        //    {
        //        int netice = (int)Math.Pow(eded, 3);
        //        Console.WriteLine("Ededin kubu: " + netice);
        //    }
        //    else Console.WriteLine("Daxil etdiyiniz eded 1 ve 100 araliginda deyil");
        //}

        // 26_______________________

        //Console.WriteLine("Adinizi Daxil Edin:");
        //string ad = Console.ReadLine();
        //Console.WriteLine("Soyadinizi Daxil Edin:");
        //string soyad = Console.ReadLine();

        //string netice = String.Concat(ad, " ", soyad);

        //Console.WriteLine("Welcome " + netice);

        //static void Concatfullname(string ad, string soyad)
        //{
        //    string netice = String.Concat(ad, " ", soyad);

        //    Console.WriteLine("Welcome " + netice);
        //}

        // 27_______________________

        //Console.WriteLine("Bir Soz Daxil Edin:");
        //string soz = Console.ReadLine();
        //int sozuzunlugu = soz.Length;

        //Console.WriteLine(soz + " - " + sozuzunlugu + " herf");

        //static void Wordlength(string soz)
        //{
        //    int sozuzunlugu = soz.Length;

        //    Console.WriteLine(soz + " - " + sozuzunlugu + " herf");
        //}

        // 28_______________________




        //Console.WriteLine("Oyunun Qaydalari:");
        //Console.WriteLine("Bir Meyve adi var onu tapmalisiniz");
        //Console.WriteLine("3 sansiniz var");
        //Console.WriteLine("3 sans ile tapsaz qazanirsiz, eks halda meglub olursuz");
        //Console.WriteLine("Baslayaq");
        //Console.WriteLine("Hansi meyvedir bu? Meyvenin adini daxil edin:");

        //int limit = 3;
        //bool check = false;

        //for (int count = 1; count <= limit; count++)
        //{
        //    string texminedilen = Console.ReadLine().ToLower();
        //    if (texminedilen == tapilmalimeyve)
        //    {
        //        Console.WriteLine("Siz qazandiniz tebrikler");
        //        check = true;
        //        break;
        //    }
        //    else if (count < limit)
        //    {
        //        Console.WriteLine("Yeniden yoxlayin");
        //    }
        //}

        //if (!check)
        //Console.WriteLine("Siz meglub oldunuz, tapmali oldugunuz meyve:" + tapilmalimeyve);


        //static void Findnamegame()
        //{
        //    string tapilmalimeyve = "alma";
        //    Console.WriteLine("Oyunun Qaydalari:");
        //    Console.WriteLine("Bir Meyve adi var onu tapmalisiniz");
        //    Console.WriteLine("3 sansiniz var");
        //    Console.WriteLine("3 sans ile tapsaz qazanirsiz, eks halda meglub olursuz");
        //    Console.WriteLine("Baslayaq");
        //    Console.WriteLine("Hansi meyvedir bu? Meyvenin adini daxil edin:");

        //    int limit = 3;
        //    bool check = false;

        //    for (int count = 1; count <= limit; count++)
        //    {
        //        string texminedilen = Console.ReadLine().ToLower();
        //        if (texminedilen == tapilmalimeyve)
        //        {
        //            Console.WriteLine("Siz qazandiniz tebrikler");
        //            check = true;
        //            break;
        //        }
        //        else if (count < limit)
        //        {
        //            Console.WriteLine("Yeniden yoxlayin");
        //        }
        //    }

        //    if (!check)
        //        Console.WriteLine("Siz meglub oldunuz, tapmali oldugunuz meyve:" + tapilmalimeyve);
        //}


        // 29_______________________

        //for (int i = 1; i <= 99; i++)
        //{
        //    if (i % 7 == 0 || i % 10 == 7)
        //    {
        //        string stri = (string)Convert.ToString(i);
        //        stri = "DIZZ";
        //        Console.Write(stri + ", ");
        //    }
        //    else
        //    {
        //        if (i != 99)        // 99 dan sonra axirinci vergul dusmesin deye if serti yazmisam
        //        {
        //            Console.Write(i + ", ");
        //        }
        //        else { 
        //            Console.WriteLine(i); 
        //        }
        //    }
        //}

        //static void DIZZgame()
        //{
        //    for (int i = 1; i <= 99; i++)
        //    {
        //        if (i % 7 == 0 || i % 10 == 7)
        //        {
        //            string stri = (string)Convert.ToString(i);
        //            stri = "DIZZ";
        //            Console.Write(stri + ", ");
        //        }
        //        else
        //        {
        //            if (i != 99)        // 99 dan sonra axirinci vergul dusmesin deye if serti yazmisam
        //            {
        //                Console.Write(i + ", ");
        //            }
        //            else
        //            {
        //                Console.WriteLine(i);
        //            }
        //        }
        //    }
        //}

        // 30_______________________

        //int[] arr = [10, 12, 22, 10, 32, 22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15];
        //int count = 1;
        //Array.Sort(arr);

        //for(int i = 1;  i < arr.Length; i++)
        //{
        //    if (arr[i] != arr[i-1])
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        //static void Differentnumbers(params int[] arr)
        //{
        //    int count = 1;
        //    Array.Sort(arr);

        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] != arr[i - 1])
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);
        //}
    }
}

