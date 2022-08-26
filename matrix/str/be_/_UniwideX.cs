using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.str.be_
{
	static public class _UniwideX
	{
		public static bool IsUniwide<T>(this IEnumerable<T[,]> item2,T[,] item1 )
		{
			return item2.All(
				m=> m.GetLength(1)==item1.GetLength(1)
			);
		}
		public static bool IsUniwide<T>(this (T[,], IEnumerable<T[,]>) p)
		{
			return IsUniwide(p.Item2, p.Item1);
			//throw new NotImplementedException();
		}

		static public bool IsUniwide<T>(this IEnumerable<T[,]> matrixes) {
			if (matrixes.Any())
			{
				return IsUniwide(
					obj.str_.started._Head1torsoX.Head1torso(matrixes)
				);
			}
			return true;
		}



	}
}
