using StringCalculator_Kata;

namespace StringCalculator_Kata
{
    public class StringCalculator
    {
        public int Add(String numbers)
        {
            String[] separator = { ",", "\n", "//", ":", "." ,";"};
            String[] listOfStrings = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            List<int> listOfIntegers = new();
            int sum = 0;

            foreach (String s in listOfStrings)
            {
                int number;
                if (int.TryParse(s, out number))
                    listOfIntegers.Add(number);
            }

            foreach (int i in listOfIntegers)
            {
                sum += i;
            }
            return sum;
        }
    }
}