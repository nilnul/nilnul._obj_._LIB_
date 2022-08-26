using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.bound_.closed.phrase_
{
	public class _HyphenAsToX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="x">inclusive</param>
		/// <param name="y">inclusive</param>
		/// <returns></returns>
		static public string Phrase<T>(T x, T y)
		{
			return $"{x}-{y}";
		}
	}
}
