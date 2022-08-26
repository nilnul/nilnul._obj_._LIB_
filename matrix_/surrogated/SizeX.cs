using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_.surrogated
{
	static public class _SizeX
	{
		static public int Count<T>(IEnumerable<IEnumerable<T>> matrix) {
			return matrix.Count();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// if 0-rows, we cannot retrieve the arity info.
		/// </exception>
		static public int Arity<T>(IEnumerable<IEnumerable<T>> matrix) {

			if (matrix.Any())
			{
				return matrix.First().Count();
			}
			throw new ArgumentException("we cannot retrieve any row to get the arity info." );
		}



	}
}
