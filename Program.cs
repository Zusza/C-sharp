﻿///Funkcje
///Zad.1.1 - Dodawanie liczb cyfry - % 10 i / 10
//int SumaCy(int n)
//{
//    int suma = 0;
//    while (n > 0)
//    {
//        suma += n % 10;
//        n = n / 10;
//    }
//    return suma;    
//}
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(SumaCy(n));

///Zad.1.2
//string napis = "etacidnyS deerC s'nissassA | rehctiW ehT | enoG syaD";
//char[] C = napis.ToCharArray();
//Array.Reverse(C);
//string wynik = new string(C);
//Console.WriteLine(wynik);
///Zad.1.3
//int z = int.Parse(Console.ReadLine());
//int f(int x)
//{
//    while(x > 0)
//    {
//        Console.Write(x + "-");
//        x = x / 2;
//    }
//    return 0;
//}
//Console.WriteLine(f(z));

///Ciągi Belgijskie
///Zad.2.1
//int reku1(int n)
//{
//    if (n == 1) return 3;
//    return reku1(n - 1) + 2;
//}
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(reku1(i));
//}

///Zad.2.3
//int reku3(int n)
//{
//    if (n == 1) return 1;
//    if (n == 2) return 1;
//    return 2*reku3(n - 2) + reku3(n - 1);
//}
//int n = int.Parse(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    Console.WriteLine(reku3(i));
//}

///Pliki
///Otwieranie pliku i dodawanie linijki - by Zee
//using System.IO;
//var files = Directory.GetFiles("C:/Users/uczen/Desktop/", "OK.txt", SearchOption.AllDirectories);
//foreach (var i in files)
//{
//    File.AppendAllText(i, " - Ezio Auditore da Firenze <3, Edward James Kenway <3, Arno Victor Dorian <3, Jacob Frye <3 -");
//}
//var x = File.ReadAllText("C:/Users/uczen/Desktop/OK.txt");
//Console.WriteLine(x);

///Zad.3.1
