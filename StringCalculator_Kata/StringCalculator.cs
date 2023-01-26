using System.Text;

namespace StringCalculator_Kata
{
    public class StringCalculator
    {
        public int Add(String numbers)
        {
            String[] separator = { ",", "\n", GetDelimiter(numbers)};
            String[] listOfStrings = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            List<int> listOfIntegers = new();
            int sum = 0;

            foreach (String s in listOfStrings)
            {
                int number;
                if (int.TryParse(s, out number))
                    listOfIntegers.Add(number);
            }

            if (NegativeList(listOfIntegers).Count > 0 )
                throw new Exception("Negative not allowed: " + NegativeListMessage(listOfIntegers).ToString());

            foreach (int i in listOfIntegers)
            {
                if (i > 1000)
                    continue;
                sum += i;
            }
            return sum;
        }

        public List<int> NegativeList(List<int> list)
        {
            List<int> negativeList = new();
            foreach (int i in list)
                if (i < 0)
                    negativeList.Add(i);
            return negativeList;
        }

        public StringBuilder NegativeListMessage(List<int> negativeList)
        {
            StringBuilder Message = new StringBuilder();
            foreach (int i in negativeList)
                Message.Append(i + " ");
            return Message;
        }

        public string GetDelimiter(string numbers)
        {
            string delimiter = "";
            if (numbers.StartsWith("//"))
            {
                delimiter = numbers.Substring(2, numbers.IndexOf('\n') - 2);
            }
            return delimiter;
        }
    }
}