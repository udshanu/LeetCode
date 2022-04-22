public class OrderedStream {

    public OrderedStream(int n) {
        this.Pointer = 0;
        this.Output = new string[n];
    }
    
    public int Pointer { get; set; }
    public string[] Output { get; set; }
    
    public IList<string> Insert(int idKey, string value) {
        int index = idKey - 1;
        this.Output[index] = value;

        List<string> result = new List<string>();

        if (this.Pointer == index)
        {
            while (this.Pointer < this.Output.Length && this.Output[this.Pointer] != null)
            {
                result.Add(this.Output[this.Pointer]);
                this.Pointer++;
            }
        }

        return result;
    }
}

/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */
