using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	public interface OrdI<  T>

	{
		bool le(T a, T b);
		bool ge(T a, T b);

		/// <summary>
		/// as Eq is derived from le
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		bool eq(T a, T b);

		bool lt(T a, T b);
		bool gt(T a, T b);

	}

}
