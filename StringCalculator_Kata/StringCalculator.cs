using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
                throw new Exception("Negative not allowed: " + NegativeListMessage(NegativeList(listOfIntegers)).ToString());

            return listOfIntegers.Where(i => i<=1000 ).Sum();
        }

        public List<int> NegativeList(List<int> list)
        {
            List<int> negativeList = list.Where(i => i < 0).ToList();
            return negativeList;
        }

        public string NegativeListMessage(List<int> negativeList)
        {
            string Message = string.Join(" ", negativeList);
            return Message;
        }

        public string GetDelimiter(string numbers)
        {
            string delimiter = "";
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Remove(0,2);
                delimiter = string.Concat(numbers.TakeWhile(x => !x.Equals('\n')));
            }
            return delimiter;
        }
    }
}