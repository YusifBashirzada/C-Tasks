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

// 26_______________________

//Console.WriteLine("Adinizi Daxil Edin:");
//string ad = Console.ReadLine();
//Console.WriteLine("Soyadinizi Daxil Edin:");
//string soyad = Console.ReadLine();

//string netice = String.Concat(ad, " ", soyad);

//Console.WriteLine("Welcome " + netice);

// 27_______________________

//Console.WriteLine("Bir Soz Daxil Edin:");
//string soz = Console.ReadLine();
//int sozuzunlugu = soz.Length;

//Console.WriteLine(soz + " - " + sozuzunlugu + " herf");

// 28_______________________

//string tapilmalimeyve = "alma";


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

// 30_______________________

//int [] arr = [10, 12, 22, 10, 32, 22, 16, 32, 22, 10, 11, 23, 32, 10, 10, 23, 23, 15];
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


// 31_______________________

//int row = 3;
//int col = 3;
//int[,] matrix = new int[row, col];

//int[,] matrixs = {
//    { 2, 5, 8 },
//    { 3, 9, 8 }
//};

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        Console.WriteLine(matrixs[i, j]);
//    }
//    Console.WriteLine();
//}

// 32_______________________
//int row = 3;
//int col = 3;
//int[,] matrix = new int[row, col];

//int[,] matrixs1 = {
//    { 2, 5, 8, },
//    { 12, 15, 1}, 
//    { 13, 16, 1},
//};

//int[,] matrixs2 = {
//    { 5, 5, 10,},
//    { 4, 9, 18}, 
//    { 6, 7, 19},
//};


//int[,] toplamatrix = new int[row, col];

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        toplamatrix[i, j] = matrixs1[i, j] + matrixs2[i, j];
//        Console.Write(" " + toplamatrix[i,  j]);
//    }
//    Console.WriteLine();
//}

// 33_______________________

//int row = 3;
//int col = 3;
//int[,] matrix = new int[row, col];

//int[,] matrixs1 = {
//    { 2, 5, 8, },
//    { 12, 15, 1},
//    { 13, 16, 1},
//};

//int[,] matrixs2 = {
//    { 5, 5, 10,},
//    { 4, 9, 18},
//    { 6, 7, 19},
//};


//int[,] toplamatrix = new int[row, col];

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < col; j++)
//    {
//        toplamatrix[i, j] = matrixs1[i, j] * matrixs2[i, j];
//        Console.Write(" " + toplamatrix[i, j]);
//    }
//    Console.WriteLine();
//}