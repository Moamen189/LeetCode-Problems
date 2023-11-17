public class Solution {
    public string Multiply(string num1, string num2) {
        var n1 = num1.Length;
        var n2 = num2.Length;
        var n3 = n1 + n2;

        var products = new int[n3];
        var sb = new StringBuilder(n3);

        for (int i = n1 - 1; i >= 0; i--)
        {
            for (int j = n2 - 1; j >= 0; j--)
            {
                int d1 = num1[i] - '0';
                int d2 = num2[j] - '0';
                int prod = d1 * d2;
                int sum = prod + products[i + j + 1]; 
                products[i + j] += sum / 10;
                products[i + j + 1] = sum % 10;
            }
        }
        
        foreach(int num in products.SkipWhile(d => d == 0))
        {
            sb.Append(num);
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}