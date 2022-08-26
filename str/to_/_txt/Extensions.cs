using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str.to_._txt
{

	/// <summary>
	
	/// </summary>
	static public  class Extensions
	{

		public const string SEPERATOR = ",";

		

		static public string ToTxt<T>(this IEnumerable<T> vector, string seperator=SEPERATOR)
		{
			if (vector.Any())
			{
				return nilnul.str_.started.X._ToTxt_byLoop(vector,seperator);

			}
			return "";

		}


		static public string ToTxt<T>(this IEnumerable<T> vector, char seperator)
		{
			
			return string.Join(seperator.ToString(),vector);

		}
		static public string ToLines<T>(this IEnumerable<T> vector)
		{
			return ToTxt(vector, Environment.NewLine);

		}


	}
}
