public class Solution {
    public int Divide(int dividend, int divisor) {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue; // Overflow case
        }

        int sign = (dividend < 0) ^ (divisor < 0) ? -1 : 1;

        long ldividend = Math.Abs((long)dividend);
        long ldivisor = Math.Abs((long)divisor);

        long quotient = 0;

        while (ldividend >= ldivisor)
        {
            long temp = ldivisor;
            long multiple = 1;

            while (ldividend >= (temp << 1))
            {
                temp <<= 1;
                multiple <<= 1;
            }

            ldividend -= temp;
            quotient += multiple;
        }

        return (int)(sign * quotient);
    }
}