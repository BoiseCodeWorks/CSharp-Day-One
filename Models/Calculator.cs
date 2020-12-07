namespace CsharpDay1.Models
{
    public class Calculator
    {
        // private string title;
        public int LastSum { get; set; }
        public string Title { get; private set; }

        public Calculator(string title)
        {
            Title = title;
        }

        public int Add(int num1, int num2)
        {
            LastSum = num1 + num2;
            return LastSum;
        }

        public int Add(int num1, int num2, int num3)
        {
            LastSum = num1 + num2 + num3;
            return LastSum;
        }
        public int Add(string num1, string num2)
        {
            int number1;
            int number2;
            int.TryParse(num1, out number1);
            int.TryParse(num2, out number2);
            LastSum = number1 + number2;
            return LastSum;
        }




    }
}