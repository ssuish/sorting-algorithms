﻿// Sorting Algorithms in C#

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

sort(numArr);
Console.WriteLine("Sorted Array: ");
printArray(numArr);

// Insertion Sort
void sort(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; ++i)
    {
        int key = arr[i];
        int j = i - 1;

        // Move elements of arr[0..i-1],
        // that are greater than key,
        // to one position ahead of
        // their current position

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }

        arr[j + 1] = key;
    }
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; ++i)
        Console.Write(arr[i] + " ");
}

// Selection Sort


// Merge Sort

