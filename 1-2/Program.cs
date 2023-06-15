class Solution
{
    public struct pos
    {
        public int x;
        public int y;
        public int direction;
        public int num;

        public pos(int x, int y, int direction, int num)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
            this.num = num;
        }
    }


    public int solution(int n)
    {
        int[,] matrix = new int[n, n];
        bool[,] visited = new bool[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                visited[i, j] = false;

        int[] dx = new int[] { 1, 0, -1, 0 };
        int[] dy = new int[] { 0, 1, 0, -1 };
               

        Queue<pos> queue = new Queue<pos>();
        queue.Enqueue(new pos(0, 0, 0, 1));
        visited[0, 0] = true;

        while(queue.Count > 0)
        {
            var top = queue.Dequeue();
            matrix[top.y, top.x] = top.num;


            int nextDir = top.direction;
            int nextX = top.x + dx[nextDir];
            int nextY = top.y + dy[nextDir];

            while (!(nextX >= 0 && nextX < n && nextY>=0 && nextY <n && !visited[nextY,nextX]))
            {
                nextDir =  (nextDir + 1 ) % 4;
                nextX = top.x + dx[nextDir];
                nextY = top.y + dy[nextDir];

                if (nextDir == top.direction)
                    break;
            }

            if (nextX >= 0 && nextX < n && nextY >= 0 && nextY < n && !visited[nextY, nextX])
            {
                visited[nextY, nextX] = true;
                queue.Enqueue(new pos(nextX, nextY, nextDir, top.num + 1));
            }
        }

        int answer = 0;
        for (int i = 0; i < n; i++)
            answer += matrix[i, i];
        return answer;
    }

    // The following is main method to output testcase.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int n1 = 3;
        int ret1 = sol.solution(n1);


        // Press Run button to receive output. 
        Console.WriteLine("Solution: return value of the method is " + ret1 + " .");

        int n2 = 2;
        int ret2 = sol.solution(n2);

        // Press Run button to receive output. 
        Console.WriteLine("Solution: return value of the method is " + ret2 + " .");
    }
}