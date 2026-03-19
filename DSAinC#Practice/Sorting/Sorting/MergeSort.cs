namespace Sorting
{
    internal class MergeSort
    {
        public static void Merge_Sort(int[] arr, int l , int r)
        {
           
            //Console.WriteLine("Merge Sort");
            //Console.WriteLine();

            if(l<r)
            {
                
                int m = l + (r - l) / 2;
                Merge_Sort(arr, l, m);
                Merge_Sort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }

            
           
        }

        public static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i, j;

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m+1 + j];
            }

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
                else// L[i]>R[j]
                {
                    arr[k] = R[j];
                    j++;
                }

                k++;// iterate org arr
            }

            while(i<n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while(j<n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

        }

        public static void Print(int[] arr)
        {
            Console.WriteLine("Printing Array");
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write($"{i},");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sorting!");

            int[] arr = [4, 67, 9, 0, 3, 5, 1, 11, 78, 87, 34, 50];

            int n = arr.Length -1 ;

            Print(arr);

            Console.WriteLine("Merge Sort"); 
            Merge_Sort(arr,0,n);

            Print(arr);


        }
    }
}
