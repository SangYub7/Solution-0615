Queue<int> q = new Queue<int>();
q.Enqueue(2);
int front = q.Dequeue();
int cnt = q.Count;


Dictionary<int, int> dic = new Dictionary<int, int>();
var keys = dic.Keys;
dic[1] = 1;
dic.Remove(1);
dic.ContainsKey(1);


List<int> list = new List<int>();
list.Add(4);
list.Remove(2);
list.Clear();

int idx = list.BinarySearch(3);



PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

pq.Enqueue(1, -1);
pq.Enqueue(5, -5);
pq.Enqueue(4, -4);
pq.Enqueue(3, -3);
pq.Enqueue(2, -2);
while (pq.Count > 0)
{
    int top = pq.Dequeue();
    Console.WriteLine(top);
}





