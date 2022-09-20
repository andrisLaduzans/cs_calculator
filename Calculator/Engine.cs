using System;
using System.Text.RegularExpressions;

namespace Engine
{
    public class Calc
    {
        private string _firstNumber;
        public string firstNumber
        {
            get { return this._firstNumber; }
        }

        private string _secondNumber;
        public string secondNumber
        {
            get { return this._secondNumber; }
        }

        private string _operation;
        public string operation
        {
            get { return this._operation; }
        }

        private string _displayString;
        public string displayString
        {
            get { return this._displayString == null ? " " : this._displayString; }
            set { this._displayString = value; }
        }

        public Calc()
        {
        }

        public string handleInput(string input)
        {
            Regex numReg = new Regex(@"^NUMBER_\d");
            bool isNumber = numReg.IsMatch(input);

            if (isNumber)
            {
                return this.handleNumber(input);
            }
            else
            {
                return this.handleOperator(input);
            }

        }

        private string handleNumber(string input)
        {
            string extractedNumberStr = input.Replace("NUMBER_", "");
            this._firstNumber += extractedNumberStr;
            return this._firstNumber;
        }

        private string handleOperator(string operation)
        {
            return "not a number";
        }
    }
}

