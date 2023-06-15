 class Solution
{
    public int solution(string pos)
    {
        int[] dx = new int[] { 2, 2, 1, 1, -1 - 1, -2 - 2 };
        int[] dy = new int[] { 1, -1, 2, -2, 2, -2, 1, -1 };

        int x = pos[0] - 'A';
        int y = pos[1] - '1';

        int answer = 0;

        for(int i = 0; i < dx.Length; i++)
        {
            int nx = x + dx[i];
            int ny = y + dy[i];

            if (nx >= 0 && nx < 8 && ny >= 0 && ny < 8)
                answer++;            
        }

        return answer;
    }

    // The following is main method to output testcase.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        string pos = "A7";
        int ret = sol.solution(pos);

        // Press Run button to receive output. 
        Console.WriteLine("Solution: return value of the method is " + ret + " .");
    }
}