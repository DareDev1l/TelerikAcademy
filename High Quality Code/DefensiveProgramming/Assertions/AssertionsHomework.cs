namespace Assertions
{
    using System;
    using System.Diagnostics;

    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SelectionSort(new int[0]); // Test sorting empty array
            SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(BinarySearch(arr, 0));
            Console.WriteLine(BinarySearch(arr, 17));
            Console.WriteLine(BinarySearch(arr, 10));
            Console.WriteLine(BinarySearch(arr, 1000));
        }

        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Array should not be empty");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(IsSorted(arr), "Array is not sorted properly");
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(startIndex >= 0, "startIndex should be a non-negative integer");
            Debug.Assert(endIndex < arr.Length, "endIndex should be an integer less than length of array");
            Debug.Assert(startIndex <= endIndex, "Both indices should be between 0 and length of array and startIndex should be less than endIndex");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(!SmallerValueExists(arr, arr[minElementIndex]), "The found value is not the minimal one");

            return minElementIndex;
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(value != null, "Value is null");
            Debug.Assert(startIndex >= 0, "startIndex should be a non-negative integer");
            Debug.Assert(endIndex < arr.Length, "endIndex should be an integer less than length of array");
            Debug.Assert(startIndex <= endIndex, "Both indices should be between 0 and length of array and startIndex should be less than endIndex");


            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            Debug.Assert(!ValueExists(arr, value), "Value exists in the arr but the algorithm doesn't find it");

            // Searched value not found
            return -1;
        }

        private static bool ValueExists<T>(T[] arr, T value) 
            where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(value) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        // Helper methods for the assertions
        private static bool IsSorted<T>(T[] arr) 
            where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool SmallerValueExists<T>(T[] arr, T value)
            where T: IComparable<T>
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(value) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
