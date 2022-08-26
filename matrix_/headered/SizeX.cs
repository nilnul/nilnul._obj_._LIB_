using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_.headered
{
	static public class _SizeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <returns></returns>
		/// 
		static public int _Arity_assumeHeadered<T>(IEnumerable<IEnumerable<T>> matrix) {
			return matrix.First().Count();
		}
		static public int Count<T>(IEnumerable<IEnumerable<T>> matrix) {
			return matrix.Count();
		}



	}
}
