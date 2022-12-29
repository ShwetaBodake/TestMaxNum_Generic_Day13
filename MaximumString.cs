using System;
namespace GenericTestMaximumNumber
{
	public class MaximumString
	{

        public static string Maximumstring(string firstValue, string secondvalue, string thirdValue)
        {
            if (firstValue.CompareTo(secondvalue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondvalue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondvalue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }


            if (secondvalue.CompareTo(firstValue) > 0 && secondvalue.CompareTo(thirdValue) > 0 ||
                secondvalue.CompareTo(firstValue) >= 0 && secondvalue.CompareTo(thirdValue) > 0 ||
                secondvalue.CompareTo(firstValue) > 0 && secondvalue.CompareTo(thirdValue) >= 0)
            {
                return secondvalue;
            }


            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondvalue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondvalue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondvalue) >= 0)
            {
                return thirdValue;
            }

            return default;
        }

    }
}

