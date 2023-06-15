
class Solution
{
    HashSet<int> set = new HashSet<int>();

    public void makeNum(int now, Dictionary<int, int> num)
    {
        if(num.Count == 0)
        {
            set.Add(now);
            return;
        }

        var keys = num.Keys.ToList();

        foreach(int key in keys)
        {

            if (num[key] == 1)
                num.Remove(key);
            else
                num[key]--;

            makeNum(now * 10 + key, num);

            if (num.ContainsKey(key))
                num[key]++;
            else
                num[key] = 1;

        }

    }


    public int solution(int[] card, int n)
    {
        set.Clear();
        int answer = -1;

        Array.Sort(card);
        Dictionary<int, int> dic = new Dictionary<int, int>();


        for (int i = 0; i < card.Length; i++)
        {
            if (dic.ContainsKey(card[i]))
                dic[card[i]]++;
            else
                dic[card[i]] = 1;
        }

        makeNum(0, dic);

        List<int> nl = set.ToList();
        nl.Sort();

        for (int i = 0; i < nl.Count; i++)
            if (n == nl[i])
                answer = i + 1;

        return answer;
    }

    // 아래는 테스트케이스 출력을 해보기 위한 main 메소드입니다.
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] card1 = new int[]{ 1, 2, 1, 3 };
        int n1 = 1312;
        int ret1 = sol.solution(card1, n1);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret1 + " 입니다.");

        int[] card2 = new int[]{ 1, 1, 1, 2 };
        int n2 = 1122;
        int ret2 = sol.solution(card2, n2);

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        Console.WriteLine("solution 메소드의 반환 값은 " + ret2 + " 입니다.");
    }
}