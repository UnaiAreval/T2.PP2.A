using System;
namespace ExerciceTwo
{
    public class ExerciceTwo
    {
        public static void Main()
        {
            // apartat a
            int[] array = { 10, 4, 6, 4, 8, -13, 2, 3 };
            BinarySearch(array, 0, array.Length, 6);

            // apartat b
            Order(array, 0, array.Length);
        }
        //llibreria per al a
        public static int BinarySearch(int[] arr, int first, int last, int key)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == key) { return mid; }
                if (arr[mid] > key)
                {
                    return BinarySearch(arr, first, mid - 1, key);//cerca en el subarray esquerre
                }
                else
                {
                    return BinarySearch(arr, mid + 1, last, key);//cerca en el subarray dret

                }
            }
            return -1;
        }
        // llibreria per al b
        public static void Complete(int[] v, int left, int m, int right) 
        {
            int n = right - left + 1;
            int[] aux = new int[n];
            int k = 0;
            int i = left;
            int j = m + 1;
            while (i <= m && j <= right)
            { 
                if (v[i] < v[j]) 
                { 
                    aux[k] = v[i]; ++i; 
                } else 
                { 
                    aux[k] = v[j]; ++j; 
                } 
                ++k; 
            } 
            while (i <= m) 
            { 
                aux[k] = v[i]; ++i; ++k; 
            } 
            while (j <= right) 
            { 
                aux[k] = v[j]; ++j; ++k; 
            } 
            for (k = 0; k < n; ++k) v[left + k] = aux[k];
        }
        public static void Order(int[] v, int left, int right)
        { 
            if (left < right) 
            {
              int m = (left + right) / 2; 
                Order(v, left, m); 
                Order(v, m + 1, right); 
                Complete(v, left, m, right); 
            } 
        }
    }
}