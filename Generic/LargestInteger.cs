using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class LargestInteger
    {
        public static int MaxNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum > thirdNum)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum > thirdNum)
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }
        }

        // UseCase2 : Given 3 Floats find the maximum


        public static double FindMax(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
    }
}
