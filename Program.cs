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
    Console.WriteLine("\nChoose a sorting method.\n [0] Insertion Sort\n [1] Selection Sort\n [2] Merge Sort");
    Console.Write("\nYour respoonse: ");
    int choosen = int.Parse(Console.ReadLine() ?? "3");

    Console.WriteLine("\r\nChoose arrangement. [0] Ascending [1] Descending");
    Console.Write("\nYour response: ");
    int arrange = int.Parse(Console.ReadLine() ?? "3");

    if (choosen == 0)
    {
        Console.Write("\r\nUnsorted Array: ");
        printArray(numArr);
        InsertionSort insertion = new InsertionSort();
        Console.ForegroundColor = ConsoleColor.Cyan;

        if (arrange == 0)
        {
            insertion.InsertionSortAsc(numArr);
            Console.WriteLine("\nSorted Array using Insertion Sort method (Ascending): ");
        }
        else if (arrange == 1)
        {
            insertion.InsertionSortDes(numArr);
            Console.WriteLine("\nSorted Array using Insertion Sort method (Descending): ");
        }

        printArray(numArr);
        Console.ResetColor();
        break;
    }
    else if (choosen == 1)
    {
        Console.Write("\r\nUnsorted Array: ");
        printArray(numArr);
        SelectionSort selection = new SelectionSort();
        Console.ForegroundColor = ConsoleColor.Cyan;

        if (arrange == 0)
        {
            selection.SelectionSortAsc(numArr);
            Console.WriteLine("\nSorted Array using Selection Sort method (Ascending): ");
        }
        else if (arrange == 1)
        {
            selection.SelectionSortDes(numArr);
            Console.WriteLine("\nSorted Array using Selection Sort method (Descending): ");
        }

        printArray(numArr);
        Console.ResetColor();
        break;
    }
    else if (choosen == 2)
    {
        Console.Write("\r\nUnsorted Array: ");
        printArray(numArr);
        MergeSort merge = new MergeSort();
        Console.ForegroundColor = ConsoleColor.Cyan;

        if (arrange == 0)
        {
            merge.MergeSorting(numArr, 0, numArr.Length - 1, arrange);
            Console.Write("\r\nSorted Array using Merge Sort (Ascending): ");
        }
        else if (arrange == 1)
        {
            merge.MergeSorting(numArr, 0, numArr.Length - 1, arrange);
            Console.Write("\r\nSorted Array using Merge Sort (Descending): ");
        }

        printArray(numArr);
        Console.ResetColor();
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