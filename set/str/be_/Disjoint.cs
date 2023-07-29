using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.str.be_
{
	static public class _DisjointX
	{
		static public bool _Be<T>(IEnumerable<T> set, IEnumerable<IEnumerable<T>> sets, IEqualityComparer<T> eq)
		{
			return Be(sets,eq) &&  sets.All( s => nilnul.obj.set.co.be_._DisjointX.Disjoint(s, set,eq));

		}

		static public bool Be<T>(IEnumerable<IEnumerable<T>> sets, IEqualityComparer<T> eq)
		{
			if (sets.Count() == 0)
			{
				return true;
			}
			else
			{
				return _Be(sets.First(), sets.Skip(1),eq);
			}
		}


		static public bool Be<T,TEq>(IEnumerable<IEnumerable<T>> sets)
			where TEq:IEqualityComparer<T>,new()
		{
			return Be(sets, nilnul.obj_.Singleton<TEq>.Instance);
		}


	}
}
