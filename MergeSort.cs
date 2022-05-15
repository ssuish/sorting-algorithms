public class MergeSort
{
    // Merge Sort

    void merge(int[] arr, int l, int m, int r, int a)
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
            if (a == 0)
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
            }
            else if (a == 1)
            {
                if (L[i] >= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
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

    public void MergeSorting(int[] arr, int l, int r, int a) 
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;

            MergeSorting(arr, l, m, a);
            MergeSorting(arr, m + 1, r, a);
            merge(arr, l, m, r, a);
        }
    }
}