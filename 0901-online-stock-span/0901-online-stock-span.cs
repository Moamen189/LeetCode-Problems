public class StockSpanner {
    Stack<int> _prices;
    Dictionary<int, int> _stockPeaks;

    public StockSpanner() {
        _prices = new Stack<int>();
        _stockPeaks = new Dictionary<int, int>(); 
    }
    
    public int Next(int price) {
        var days = 1;

        while(_prices.Count != 0 && _prices.Peek() <= price)
        {
            var lowerOrEqualPrice = _prices.Pop();
            days += _stockPeaks[lowerOrEqualPrice];
            _stockPeaks.Remove(lowerOrEqualPrice);
        }

        _prices.Push(price);
        _stockPeaks[price] = days;

        return days;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */