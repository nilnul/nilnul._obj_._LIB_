using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.net_.ord_
{
	/// <summary>
	/// 字体越小，优先级越高.
	/// so
	///		2^3^5= 2^(3^5)
	/// </summary>
	public class Priority<T>
		:
		nilnul.obj.ReI<nilnul.obj.op_.BinaryI<T>>
	{
		/// <summary>
		/// less than or eq
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool re(BinaryI<T> a, BinaryI<T> b)
		{
			throw new NotImplementedException();
		}
	}
}
