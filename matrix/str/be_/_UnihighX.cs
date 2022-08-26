using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.str.be_
{
	static public class _UnihighX
	{
		public static bool IsUnihigh<T>(this IEnumerable<T[,]> item2,T[,] item1 )
		{
			return item2.All(
				m=> m.GetLength(0) ==item1.GetLength(0)
			);
		}
		public static bool IsUnihigh<T>(this (T[,], IEnumerable<T[,]>) p)
		{
			return IsUnihigh(p.Item2, p.Item1);
			//throw new NotImplementedException();
		}

		static public bool IsUnihigh<T>(this IEnumerable<T[,]> matrixes) {
			if (matrixes.Any())
			{
				return IsUnihigh(
					obj.str_.started._Head1torsoX.Head1torso(matrixes)
				);
			}
			return true;
		}



	}
}
