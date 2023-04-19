//Stworzenie tablicy 10 losowych liczb <1;20>
///Stwórz tablicę
//Random r = new Random();
//int n = 10;
//int[] T = new int[n];
//for (int i = 0; i < n; i++)
//{
//    T[i] = r.Next(1, 20);
//    Console.Write(T[i] + " ");
//}

///Posortuj w wybrany sposób:
//Sortowanie przez porównanie:
//1.Sortowanie bąbelkowe:
//od prawej rosnąco:
//int temp;
//for (int i = n - 1; i >= n; i--)
//{
//    for (int j = 0; j < i; j++)
//    {
//        if (T[j] > T[j + 1])
//        {
//            temp = T[j];
//            T[j] = T[j + 1];
//            T[j + 1] = temp;
//        }
//    }
//}

//2.Sortowanie przez wybór:
//wybieramy najmniejszy i wstawiamy go na początek:
//int k;
//int temp;
//for (int i = 0; i < n; i++)
//{
//    k = i;
//    for (int j = i + 1; j < n; j++)
//    {
//        if (T[j] > T[k]) k = j;
//        temp = T[i];
//        T[i] = T[k];
//        T[k] = temp;
//    }
//}
//wybieramy najmniejszy i wstawiamy go na koniec:
//int k;
//int temp;
//for (int i = n - 1; i > 0; i--)
//{
//    k = i;
//    for (int j = 0; j < i; j++)
//    {
//        if (T[j] < T[k]) k = j;
//        temp = T[i];
//        T[i] = T[k];
//        T[k] = temp;
//    }
//}

//3.Sortowanie przez wstawianie:
//int temp;
//int j;
//for (int i = 1; i < n; i++)
//{
//    temp = T[i];
//    j = i - 1;
//    while (temp > T[j] && j > 0)
//    {
//        T[j] = T[j - 1];
//        j--;
//    }
//    T[j - 1] = temp;
//}

//Sortowana w czasie liniowym:
//4.Sortowanie przez zliczanie
//5.Sortowanie kubełkowe

//Sortowanie przez dzielenie (dziel i zwyciężaj):
//6.Sortowanie przez scalanie
//7.Quicksort Hoare
//8.Quicksort Lomuto

//Wyświetlenie posortowanej tablicy
//Console.WriteLine("\n");
//for (int i = 0; i < n; i++)
//    Console.Write(T[i] + " ");