namespace HelpfulStuff
{
    public static class Methods
    {
        public static int[] InputToIntArray(string path)
        {
            List<int> inputs = new List<int>();
            foreach(var input in File.ReadLines(path))
            {
                if(int.TryParse(input, out int numToAdd))
                {
                    inputs.Add(numToAdd);
                }
            }
            return inputs.ToArray();
        }

        public static int Sum(in int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            return result;
        }

        public static int CountIncreaseFromRange(string path, int range)
        {
            var input = InputToIntArray(path);
            int increases = 0;

            int rangeSum = 0;
            int lastRangeSum = 0;
            for (int i = 0; i < input.Length - range; i++)
            {
                rangeSum = Sum(input[i..(i + range)]);
                if (rangeSum > lastRangeSum) { increases++; }
                lastRangeSum = rangeSum;
            }

            return increases;
        }
    }
}