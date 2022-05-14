// Sorting Algorithms in C#

/*
Create a complete C# program that allows user to input a series of integers and arrange 
these in ascending and descending order applying the logical concepts involved in the 
following sorting algorithms: Insertion Sort, Selection Sort or Merge Sort.
*/

int[] numArr = new int[10];
for (int i = 0; i < numArr.Length; i++)
{
    Console.Write("Input a series of integers (up to 10 intergers only): ");
    numArr[i] = int.Parse(Console.ReadLine() ?? "0");
}

while (true)
{
    Console.WriteLine("\nChoose a sorting method.\n [0]Insertion Sort\n [1]Selection Sort\n [2]Merge Sort");
    Console.Write("\nYour respoonse: ");
    int choosen = int.Parse(Console.ReadLine() ?? "3");

    if (choosen == 0)
    {
        Console.WriteLine("\nArray: ");
        printArray(numArr);
        InsertionSort(numArr);
        Console.WriteLine("\nSorted Array using Insertion Sort method: ");
        printArray(numArr);
        break;
    }
    else if (choosen == 1)
    {
        Console.WriteLine("\nArray: ");
        printArray(numArr);
        SelectionSort(numArr);
        Console.WriteLine("\nSorted Array using Selection Sort method: ");
        printArray(numArr);
        break;
    }
    else if (choosen == 2)
    {
        Console.WriteLine("\nArray: ");
        printArray(numArr);
        MergeSort(numArr, 0, numArr.Length - 1);
        Console.WriteLine("\nSorted Array using Merge Sort method: ");
        printArray(numArr);
        break;
    }
    else
    {
        Console.WriteLine("\nInvalid Input");
    }
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; ++i)
        Console.Write(arr[i] + " ");
}

// Insertion Sort
void InsertionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; ++i)
    {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }

        arr[j + 1] = key;
    }
}

// Selection Sort
static void SelectionSort(int[] arr)
{
    int n = arr.Length;

    for (int i = 0; i < n - 1; i++)
    {
        int min_idx = i;
        for (int j = i + 1; j < n; j++)
            if (arr[j] < arr[min_idx])
                min_idx = j;
        int temp = arr[min_idx];
        arr[min_idx] = arr[i];
        arr[i] = temp;
    }
}

// Merge Sort

void merge(int[] arr, int l, int m, int r)
{
    int n1 = m - l + 1;
    int n2 = r - m;

    int[] L = new int[n1];
    int[] R = new int[n2];
    int i, j;

    for (i = 0; i < n1; ++i)
        L[i] = arr[l + i];
    for (j = 0; j < n2; ++j)
        R[j] = arr[m + 1 + j];

    i = 0;
    j = 0;

    int k = l;
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    while (i < n1)
    {
        arr[k] = L[i];
        i++;
        k++;
    }

    while (j < n2)
    {
        arr[k] = R[j];
        j++;
        k++;
    }
}

void MergeSort(int[] arr, int l, int r)
{
    if (l < r)
    {
        int m = l + (r - l) / 2;

        MergeSort(arr, l, m);
        MergeSort(arr, m + 1, r);
        merge(arr, l, m, r);
    }
}