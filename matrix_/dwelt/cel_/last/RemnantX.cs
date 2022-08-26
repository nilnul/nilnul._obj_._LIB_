using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_.dwelt.cel_.last
{
	static public class _RemnantX
	{
		static public T[,] _Peel_assumeDwelt<T>(this T[,] x) {
			return matrix.cel._RemnantX._Remnant_celAssumeValid(
				x,
				x.GetLength(0) - 1,
				x.GetLength(1) - 1
			);
		}
	}
}
