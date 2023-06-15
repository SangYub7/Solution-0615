class Solution
{

    public struct qItem
    {
        public int pos;
        public int cnt;

        public qItem(int pos, int cnt) {
            this.pos = pos;
            this.cnt = cnt;
        }
    }


    public int solution(int number, int target)
    {
        int answer = 0;

        Queue<qItem> q = new Queue<qItem>();
        q.Enqueue(new qItem(number,0));

        HashSet<int> visited = new HashSet<int>();
        visited.Add(number);

        while(q.Count > 0 )
        {
            var now = q.Dequeue();

            if(now.pos == target)
            {
                answer = now.cnt;
                break;
            }


            if( visited.Add( now.pos + 1))
            {
                q.Enqueue(new qItem(now.pos + 1, now.cnt + 1));
            }

            if (visited.Add(now.pos - 1))
            {
                q.Enqueue(new qItem(now.pos - 1, now.cnt + 1));
            }

            if (visited.Add(now.pos * 2))
            {
                q.Enqueue(new qItem(now.pos * 2, now.cnt + 1));
            }
        } 

        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(String[] args)
    {
        Solution sol = new Solution();
        int number1 = 5;
        int target1 = 9;
        int ret1 = sol.solution(number1, target1);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret1 + " 입니다.");

        int number2 = 3;
        int target2 = 11;
        int ret2 = sol.solution(number2, target2);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret2 + " 입니다.");
    }
}