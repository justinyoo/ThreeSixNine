using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OpenTutorials.Quizes
{
	public partial class ThreeSixNine
	{
		public static string Execute(int maxNumber = 100)
		{
			List<string> results = new List<string>();
			try
			{
				if (maxNumber > 0)
				{
					for (int i = 1; i <= maxNumber; i++)
					{
						int xs = Regex.Matches(Convert.ToString(i), "[369]").Count;
						results.Add(xs == 0 ? Convert.ToString(i) : new String('X', xs));
					}
				}
				else
					throw new ArgumentOutOfRangeException("maxNumber", "maxNumber must be greater than zero.");
			}
			catch (Exception ex)
			{
				results.Add(ex.Message);
			}
			return String.Join(" ", results);
		}
	}
}
