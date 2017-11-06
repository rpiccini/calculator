using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    class PolishCalculator
    {
        enum CALCULATION_TYPE
        {
            none,
            calculationOccurred,
            enterOccurred
        }
        private String[] displayValue = new String[4];
        private CALCULATION_TYPE eventOccurred;

        public String[] returnDisplayValue() { return displayValue; }

        public void buildDisplayValue(char c)
        {
            if (eventOccurred == CALCULATION_TYPE.enterOccurred)
            {
                eventOccurred = CALCULATION_TYPE.none;
                displayValue[0] = c.ToString();
            }
            else if (eventOccurred == CALCULATION_TYPE.calculationOccurred)
            {
                eventOccurred = CALCULATION_TYPE.none;
                displayValue[3] = displayValue[2];
                displayValue[2] = displayValue[1];
                displayValue[1] = displayValue[0];
                displayValue[0] = c.ToString();
            }
            else if (displayValue[0][0] == '0' && displayValue[0].Length == 1)
                displayValue[0] = c.ToString();
            else
                displayValue[0] += c.ToString();
        }
        public void clearAll()
        {
            for (int i = 0; i < 4; ++i)
                displayValue[i] = "0";
            eventOccurred = CALCULATION_TYPE.none;
        }

        public void clear()
        {
            if (displayValue[0].Length == 1 || eventOccurred == CALCULATION_TYPE.enterOccurred)
                displayValue[0] = "0";
            else
                displayValue[0] = displayValue[0].Substring(0, displayValue[0].Length - 1);
        }

        public void pop()
        {
            displayValue[0] = displayValue[1];
            displayValue[1] = displayValue[2];
            displayValue[2] = displayValue[3];
            displayValue[3] = "0";
        }

        public void swap()
        {
            double temp = Convert.ToDouble(displayValue[0]);
            displayValue[0] = displayValue[1];
            displayValue[1] = temp.ToString();
            eventOccurred = CALCULATION_TYPE.calculationOccurred;
        }

        public void plus()
        {
            displayValue[0] = (Convert.ToDouble(displayValue[1]) + Convert.ToDouble(displayValue[0])).ToString();
            displayValue[1] = displayValue[2];
            displayValue[2] = displayValue[3];
            displayValue[3] = "0";
            eventOccurred = CALCULATION_TYPE.enterOccurred;
        }

        public void subtract()
        {
            displayValue[0] = (Convert.ToDouble(displayValue[1]) - Convert.ToDouble(displayValue[0])).ToString();
            displayValue[1] = displayValue[2];
            displayValue[2] = displayValue[3];
            displayValue[3] = "0";
            eventOccurred = CALCULATION_TYPE.enterOccurred;
        }

        public void multiply()
        {
            displayValue[0] = (Convert.ToDouble(displayValue[1]) * Convert.ToDouble(displayValue[0])).ToString();
            displayValue[1] = displayValue[2];
            displayValue[2] = displayValue[3];
            displayValue[3] = "0";
            eventOccurred = CALCULATION_TYPE.enterOccurred;
        }

        public void divide()
        {
            displayValue[0] = (Convert.ToDouble(displayValue[1]) / Convert.ToDouble(displayValue[0])).ToString();
            displayValue[1] = displayValue[2];
            displayValue[2] = displayValue[3];
            displayValue[3] = "0";
            eventOccurred = CALCULATION_TYPE.enterOccurred;
        }

        public void exponent()
        {
            displayValue[0] = (Math.Pow(Convert.ToDouble(displayValue[1]), Convert.ToDouble(displayValue[0]))).ToString();
            displayValue[1] = displayValue[2];
            displayValue[2] = displayValue[3];
            displayValue[3] = "0";
            eventOccurred = CALCULATION_TYPE.enterOccurred;
        }

        public void sqrt()
        {
            displayValue[0] = (Math.Sqrt(Convert.ToDouble(displayValue[0]))).ToString();
        }

        public void inverse()
        {
            if (Convert.ToDouble(displayValue[0]) != 0)
            {
                displayValue[0] = (1 / (Convert.ToDouble(displayValue[0]))).ToString();
            }
        }

        public void plusMinus()
        {
            if (Convert.ToDouble(displayValue[0]) != 0)
            {
                displayValue[0] = (-(Convert.ToDouble(displayValue[0]))).ToString();
            }
        }

        public void enter()
        {
            displayValue[3] = displayValue[2];
            displayValue[2] = displayValue[1];
            displayValue[1] = displayValue[0];
            eventOccurred = CALCULATION_TYPE.enterOccurred;
        }
    }
}
