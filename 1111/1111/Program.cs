// Tablouri/vectori// Array


//Console.ReadKey();
//int[] arr;
//arr = InitArray(10);
//PrintArray(arr);

//int[] arr1 = InitRandomArray(10, 1000);
//PrintArray(arr1);


//int[] arr2 = InitRandomArray2(10, 1000, 10000);
//PrintArray(arr2);



// Generez un vector cu un milion de elemente ale 
// caror valori sunt cuprinse intre 0 si 99
//int[] arr3 = InitRandomArray(1000000, 100);
//int[] f = Frequency(arr3, 100);
//PrintArray(f);

//int[] arr4 = InitRandomArray(1000, 100);
//PrintArray(arr4);

//int[] arr5 = Frequency(arr4, 100);
//CountingSort(arr5);

void CountingSort(int[] arr5)
{
    for(int n = 0;  n < arr5.Length; n++)
        for(int i = 0; i < arr5[n]; i++)
            Console.Write($"{n} ");
    Console.WriteLine();
}

// 0 1 2 3 
// 4 5 0 7....



int[] Frequency(int[] arr, int maxValue)
{
    int[] f = new int[maxValue];
    for (int i = 0; i < arr.Length; i++)
        f[arr[i]]++;
    return f;
}




int[] InitRandomArray2(int n, int start, int end)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(start, end);
    return arr;
}



int[] InitRandomArray(int n, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(maxValue);
    return arr;
}



void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] InitArray(int n)
{
    return new int[n];
}


// Se da un vector de n numere naturale - a
// se cere sa se determina cea mai mare diferenta
// a[i] - a[j], 0 <= i < j < n
// Exemplu: 0 5 9 8 1 4 6 3 2 - rezultatul este 8 = 9 - 1

//int[] a = InitRandomArray(1000000, 1000);
//int result = Solve(a);
////PrintArray(a);
//Console.WriteLine(result);


// O(n^2)
int Solve(int[] a)
{
    int maxim = int.MinValue;


    for(int i = 0; i < a.Length;i++)
        for(int j = i + 1;  j < a.Length;j++)
            if (a[i] - a[j] > maxim)
                maxim = a[i] - a[j];
    return maxim;
}


// 
int i = 20;
int[] v = {0, 1, 2, 3, 4};
if(i < v.Length && v[i] > 0)
    Console.WriteLine("OK");
else 
    Console.WriteLine("not OK");


if (v[i] > 0 && i < v.Length)
    Console.WriteLine("OK");
else
    Console.WriteLine("not OK");




 