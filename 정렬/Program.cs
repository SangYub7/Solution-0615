
class Solution
{
    public struct tempStruct
    {
        public int A;
        public int B;
        public tempStruct(int A, int B)
        {
            this.A = A;
            this.B = B;
        }
    }

    public static int cmp ( tempStruct left, tempStruct right)
    {
        if (left.A > right.A)
            return 1;
        else if (left.A < right.A)
            return -1;
        else
        {
            if (left.B > right.B)
                return 1;
            else if (left.B < right.B)
                return -1;
            else
                return 0;
        }

    }

     public static void Main(string[] args)
    {
        int[] array = new int[] { 3, 2, 3, 4, 1 };
        Array.Sort(array);
        int idx = Array.BinarySearch(array, 4);


        List<int> li = new List<int>() { 45, 34, 34, 23, 1, 23 };
        li.Sort();
        

        List<tempStruct> lits = new List<tempStruct>();
        lits.Add(new tempStruct(9, 3));
        lits.Add(new tempStruct(1, 2));
        lits.Add(new tempStruct(4, 2));
        lits.Add(new tempStruct(5, 3));
        lits.Add(new tempStruct(6, 5));
        lits.Add(new tempStruct(9, 2));

        lits.Sort(cmp);

        Console.WriteLine();



    }
}