public class RecentCounter {

    public RecentCounter() {
        this.TimeList = new Queue<int>();
    }
    
    public Queue<int> TimeList { get; set; }
    
    public int Ping(int t) {
        this.TimeList.Enqueue(t);

        while (TimeList.Peek() < (t - 3000))
        {
            TimeList.Dequeue();
        }

        return this.TimeList.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
