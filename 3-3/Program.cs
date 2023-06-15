class Solution
{
    public int solution(string[] bishops)
    {
        // 여기에 코드를 작성해주세요.


        int[,] matrix = new int[8, 8];
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                matrix[i, j] = 0;

        for(int i = 0; i < bishops.Length; i++)
        {
            int x = bishops[i][0] - 'A';
            int y = bishops[i][1] - '1';

            matrix[y, x] = 1;

            int d = 1;
            while( x + d <8 && y +d <8 )
            {
                matrix[y + d, x + d] = 1;
                d++;
            }

            d = 1;
            while (x - d >=0 && y + d < 8)
            {
                matrix[y + d, x - d] = 1;
                d++;
            }
            d = 1;
            while (x - d >= 0 && y - d >=0)
            {
                matrix[y - d, x - d] = 1;
                d++;
            }
            d = 1;
            while (x + d < 8 && y - d >=0)
            {
                matrix[y - d, x + d] = 1;
                d++;
            }
        }
        
        int answer = 0;
        for (int i = 0; i < 8; i++)
            for (int j = 0; j < 8; j++)
                if (matrix[i, j] == 0)
                    answer++;
        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        string[] bishops1 = { new string("D5") };
        int ret1 = sol.solution(bishops1);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret1 + " 입니다.");

        string[] bishops2 = { new string("D5"), new string("E8"), new string("G2") };
        int ret2 = sol.solution(bishops2);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret2 + " 입니다.");
    }
}