using System;
namespace GenericTestMaximumNumber
{
	public class RefactorCodeMaxNum 
    {
		public T MaxNum<T>(T firstValue,T secondValue, T thirdValue) where  T : IComparable
		{

			if (firstValue.CompareTo(secondValue )>0 && firstValue.CompareTo(thirdValue)>0)
			{
				return firstValue;
			}
			else if (secondValue.CompareTo(firstValue)>0 && secondValue.CompareTo(thirdValue)>0)
			{
				return secondValue;
			}
			else if (thirdValue.CompareTo(firstValue)>0 && thirdValue.CompareTo(secondValue)>0)
			{
				return thirdValue;
			}
			else
				return firstValue;

		}
	}
}

