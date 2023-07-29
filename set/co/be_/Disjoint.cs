using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.obj.set.co.be_
{

	static public class _DisjointX
	{

		static public bool Disjoint<T>(IEnumerable<T> a, IEnumerable<T> b, IEqualityComparer<T> eq)
		{
			return !_JointX.Joint(a, b, eq);
		}

		static public bool Disjoint<T, TEq>(IEnumerable<T> a, IEnumerable<T> b)
		where TEq : IEqualityComparer<T>, new()
		{

			return Disjoint<T>(a, b, nilnul.obj_.Singleton<TEq>.Instance);

		}


	}
}
