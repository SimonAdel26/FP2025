// Sortare. 

using System.Globalization;

int[] arr = InitRandomArray(10);

//Array.Sort(arr);

PrintArray(arr);
//BubbleSort(arr);
//SelectionSort(arr);
InsertionSort(arr);
PrintArray(arr);


//for i = 2:n,
//    for (k = i; k > 1 and a[k] < a[k - 1]; k--)
//        swap a[k, k - 1]
//    → invariant: a[1..i] is sorted
//end
void InsertionSort(int[] arr)
{
    for(int i = 1; i < arr.Length; i++)
    {
        for (int k = i; k > 0 && arr[k] < arr[k - 1]; k--)
            (arr[k], arr[k - 1]) = (arr[k - 1], arr[k]);
    }
}




//for i = 1:n,
//    k = i
//    for j = i + 1:n, if a[j] < a[k], k = j
//    → invariant: a[k] smallest of a[i..n]
//    swap a[i, k]
//    → invariant: a[1..i] in final position
//end
void SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int k = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[k])
                k = j;
        }
        (arr[i], arr[k]) = (arr[k], arr[i]);
    }
}




//for i = 1:n,
//    swapped = false
//    for j = n:i + 1,
//        if a[j] < a[j - 1],
//            swap a[j, j - 1]
//            swapped = true
//    → invariant: a[1..i] in final position
//    break if not swapped
//end
void BubbleSort(int[] arr)
{
    bool swapped;
    for(int i = 0; i < arr.Length; i++)
    {
        swapped = false; 
        for(int j = arr.Length - 1; j > i; j--)
        {
            if (arr[j] < arr[j - 1])
            {
                swapped = true;
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
            }
        }
    }
}



void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] InitRandomArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(1000);
    return arr;
}