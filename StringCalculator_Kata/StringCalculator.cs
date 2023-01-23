using StringCalculator_Kata;
using System.Text;

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

            if (ContainNegativeNumbers(listOfIntegers))
                throw new Exception("Negative not allowed: " + NegativeList(listOfIntegers).ToString());

            foreach (int i in listOfIntegers)
            {
                sum += i;
            }
            return sum;
        }

        public bool ContainNegativeNumbers(List<int> list)
        {
            foreach (int i in list)
                if (i < 0)
                    return true;
            return false;
        }

        public StringBuilder NegativeList(List<int> list)
        {
            StringBuilder negativeList = new StringBuilder();
            foreach (int i in list)
                if (i < 0)
                    negativeList.Append(i + " ");
            return negativeList;
        }
    }
}