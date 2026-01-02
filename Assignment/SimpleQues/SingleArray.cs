using System;
namespace SimpleQues.SingleArray;

public class SingleArray
{
    public static T[] MergeSortedArrays<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int n = a.Length;
        int m = b.Length;

        T[] merged = new T[n + m];

        int i = 0, j = 0, k = 0;

        // Merge both arrays
        while(i < n && j < m)
        {
            if(a[i].CompareTo(b[j]) <= 0)
            {
                merged[k++] = a[i++];
            }
            else
            {
                merged[k++] = b[j++];
            }
        }

        // Copy remaining elements of a
        while(i < n)
        {
            merged[k++] = a[i++];
        }

        // Copy remaining elements of b
        while(j < m)
        {
            merged[k++] = b[j++];
        }

        return merged;
    }
}