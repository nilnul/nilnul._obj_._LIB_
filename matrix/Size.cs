using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix
{
	/// <summary>
	/// regarded as a str of vecs.
	/// The length is the cardinality of the str
	/// the arity is the cardinality of the vec.
	/// the size is denoted as : length * arity.
	/// avoid rows*cols, or height * width, as <see cref="matrix.op_.unary_.ITranspose"/>, we might use different writing system, such as r2l, l2r, t2d, d2t, to phrase <see cref="matrix.phrase_"/>. And rows*cols describes the visual rendition, not the data itself.
	/// </summary>
	static public class _SizeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <returns></returns>
		///  <exception cref="ArgumentException">
		/// if 0-rows, we cannot retrieve the arity info. that's why we need the 2d-array.
		/// </exception>
		static public int Arity<T>(this IEnumerable<IEnumerable<T>> matrix)
		{
			return matrix.First().Count();
			
		}

		static public int Count<T>(this IEnumerable<IEnumerable<T>> matrix)
		{
			return matrix.Count();
		}
	}
}
