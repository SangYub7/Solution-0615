class Solution
{
    public bool isPrime(long num)
    {
        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num % i == 0)
                return false;

        }
        return true;
    }

    public int solution(int a, int b)
    {
        // 여기에 코드를 작성해주세요.
        int answer = 0;


        for (long i = 2; i <= Math.Sqrt(b); i++)
        {
            if(isPrime(i))
            {
                if (a <= i * i && i * i <= b)
                    answer++;

                if (a <= i*i * i && i * i * i <= b)
                    answer++;


            }

        }


        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int a = 6;
        int b = 30;
        int ret = sol.solution(a, b);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");
    }
}