class Solution
{
    public string solution(int hour, int minute)
    {
        string answer = "";
        float mdgree = 360 / 60 * minute;
        float hdgree = 360 / 12 * hour + 360 / 12 / (float)60 * minute;


        if (mdgree > hdgree)
            answer = (mdgree - hdgree).Tostring("0.0");
        else
            answer = (hdgree - mdgree).Tostring("0.0");

        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int hour = 1;
        int minute = 40;
        string ret = sol.solution(hour, minute);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret + " 입니다.");
    }
}