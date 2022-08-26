using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tup
{
	/// <summary>
	/// take the k-th component of the n-tup, where k le n.
	/// </summary>
	static public class _ProjectionX
	{
		static public T Projection<T>(Tuple<T, T, T, T> tuple, uint i)
		{
			switch (i)
			{
				case 0:
					return tuple.Item1;
				case 1:
					return tuple.Item2;
				case 2:
					return tuple.Item3;
				case 3:
					return tuple.Item4;
				default:
					throw new IndexOutOfRangeException();
					break;
			}
		}
	}
}
