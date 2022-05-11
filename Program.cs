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

// Insertion Sort

// Selection Sort

// Merge Sort