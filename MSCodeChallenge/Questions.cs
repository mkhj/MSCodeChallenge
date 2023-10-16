using System;
namespace MSCodeChallenge
{
    /// <summary>
    /// A list of some of the potential questions you could be presented with.
    /// You have 10-15 min so solve as many as possible.
    /// You are not allow to use any libraries etc.
    /// </summary>
    public class Questions
	{
        /// <summary>
        /// Calculate the result based on the operator (e.g +-/*)
        /// </summary>
        /// <param name="operand1">Operand1.</param>
        /// <param name="operand2">Operand2.</param>
        /// <param name="operate">Operate.</param>
        public int Calculator(int operand1, int operand2, char operate)
        {
            var result = 0;

            switch (operate)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '/':
                    result = operand1 / operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                default:
                    // Do nothing;
                    break;
            }


            return result;
        }


        /// <summary>
        /// Findet Factorial af tallene op til og med number f.eks. Input: 5 Output: 120 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public long Factorial(int number)
        {
            var results = 1;

            for (var n = 1; n <= number; n++)
            {
                results *= n;
            }

            return results;
        }

        /// <summary>
        /// Finder gennemsnitter af tallene i numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int FindAverage(int[] numbers)
        {
            var sum = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        /// <summary>
        /// Finder antallet af omtrædener af FrequenceOf i text.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="FrequenceOf"></param>
        /// <returns></returns>
        public int FindFrequence(string text, char FrequenceOf)
        {
            var count = 0;

            for (var i = 0; i < text.Length; i++)
            {
                if (text[i] == FrequenceOf)
                {
                    count++;
                }
            }

            return count;
        }


        /// <summary>
        /// Find det største tal, af a og b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Largest(int a, int b)
        {
            return (a < b) ? b : a;
        }

        /// <summary>
        /// Finder ud af om input er et Palimdrom, altså hvis man vender teksten om, om det er det samme som før, altså f.eks. Abba = True, og Ost = False
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Palindrom(string input)
        {
            var lenght = input.Length;

            for (var i = 0; i < lenght; i++)
            {
                if (input[i] != input[lenght - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Findet det andet højeste tal i Numbers f.eks. Input: 6,2,34,7,9 Output: 9
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int SecondHighst(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[numbers.Length - 2];
        }

        /// <summary>
        /// Finder summen af alle lige tal op til limit.
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public int SumEven(int limit)
        {
            var results = 0;

            for (var n = 0; n <= limit; n++)
            {
                if (n % 2 == 0)
                {
                    results += n;
                }
            }

            return results;
        }

        /// <summary>
        /// Find summen af tallene i anden op til number. F.eks. input: 5 Output: 30
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public long SumSquares(int number)
        {
            var results = 0;

            for (var n = 1; n < number; n++)
            {
                results += n * n;
            }

            return results;
        }

        /// <summary>
        /// Finder volumen ud fra højden, breden, og dybten
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public int Volume(int height, int width, int depth)
        {
            return height * width * depth;
        }

        /// <summary>
        /// Tæl antallet af ord. f.eks. input: "Hello, World!" , output = 2
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int WordCount(string text)
        {
            throw new NotImplementedException();
        }
    }
}

