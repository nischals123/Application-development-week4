namespace Task3
{
    public class ParameterDemo
    {
        public void Increase(ref int number)
        {
            number += 10;
        }

        public void GetFullName(out string fullname)
        {
            fullname = "Nischal Shrestha";
        }

        public int SumAll(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int sum = 0;
            foreach (var n in numbers)
            {
                sum += n;
            }
            return sum;
        }
    }
}