namespace zadanie4
{
    class Token
    {
        public Token(string Value)
        {
            this.Value = Value;
        }
        public string Value { get; private set; }

        public bool isNumber() => double.TryParse(Value, out _);

        public bool isOperator() => Value.IndexOfAny("+-*/".ToCharArray()) >= 0;

        public int GetPriority()
        {
            switch (Value)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default: return -1;
            }

        }

        public double GetDoubleValue() => double.Parse(Value);
    }
}