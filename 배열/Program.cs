// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
    array[i] = 0;

int[] array2 = new int[] { 1,2,3,4,5};
int[] array3 = {1,2,3,4,5};


int[,] array2D = new int[5, 6];

int dim = array2D.Rank;

int len1 = array2D.GetLength(0); // 5
int len2 = array2D.GetLength(1); // 6 



int[,] array2D2 = new int[,] { {3,2,1 },{4,3,2 } };

int[,] array2D3 = { { 2, 2, 2 }, { 3, 3, 3 } };


int[][] arrayD = new int[5][];

for (int i = 0; i < arrayD.Length; i++)
    arrayD[i] = new int[4];





Console.WriteLine();