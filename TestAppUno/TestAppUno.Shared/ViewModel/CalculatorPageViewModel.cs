﻿using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Windows.Input;

namespace TestAppUno.ViewModels
{
    public class CalculatorPageViewModel : BaseViewModel
    {
        int currentState = 1;
        string mathOperator;
        double firstNumber = 0, secondNumber = 0;
        private string _result = "0";

        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectNumber => new Command<string>(OnSelectNumber);
        public ICommand Clear => new Command(OnClear);
        public ICommand SelectOperator => new Command<string>(OnSelectOperator);
        public ICommand Calculate => new Command(OnCalculate);

        public void OnSelectNumber(string numberPressed)
        {
            if (Result == "0" || currentState < 0)
            {
                Result = "";
                if (currentState < 0)
                    currentState *= -1;
            }

            double number;
            if (double.TryParse(numberPressed, out number))
            {
                Result += number.ToString("N0");
                if (currentState == 1)
                {
                    firstNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }

        public void OnSelectOperator(string operation)
        {
            if (Result != "0")
            {
                Result += operation;
            }

            currentState = 2;
            string pressed = operation;
            mathOperator = pressed;
        }

        public void OnClear()
        {
            firstNumber = 0;
            secondNumber = 0;
            currentState = 1;
            Result = "0";
        }

        public void OnCalculate()
        {
            if (currentState == 2)
            {
                var _result = SimpleCalculator.Calculate(firstNumber, secondNumber, mathOperator);

                Result = _result.ToString();
                firstNumber = _result;
                currentState = -1;
            }
        }
    }
}