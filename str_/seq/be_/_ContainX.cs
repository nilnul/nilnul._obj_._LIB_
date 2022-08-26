using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq
{
	static  public class _ContainX
	{
		static public bool Contain<T>(this nilnul.obj.str_.EnumableI2<T> obj,T ele, IEqualityComparer<T> eq )
		{
			return obj.Contains(ele, eq);
		}

		static public bool _Contain<T>(this IEnumerable<T> _obj,T ele, IEqualityComparer<T> eq )
		{
			return _obj.Contains(ele, eq);
		}

	}
}
