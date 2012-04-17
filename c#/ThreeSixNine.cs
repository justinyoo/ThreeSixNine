using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OpenTutorials.Quizes
{
	/// <summary>
	/// This represents the 3-6-9 game.
	/// </summary>
	public partial class ThreeSixNine
	{
		/// <summary>
		/// Performs the 3-6-9 game.
		/// </summary>
		/// <param name="maxNumber">Maximum number to perform the 3-6-9 game.</param>
		/// <returns>Returns the result.</returns>
		/// <exception cref="ArgumentOutOfRangeException">Throws an exception if maximum number is less than or equal to zero.</exception>
		public static string Perform(int maxNumber = 100)
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
					throw new ArgumentOutOfRangeException("maxNumber", "Maximum number must be greater than zero.");
			}
			catch (Exception ex)
			{
				results.Add(ex.Message);
			}
			return String.Join(" ", results);
		}
	}
}
