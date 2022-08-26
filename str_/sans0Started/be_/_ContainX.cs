using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sans0Started.be_
{
	static  public class _ContainX
	{
		static public bool Contain<T>(this nilnul.obj.str_.Sans0StartedI<T> obj,T ele, IEqualityComparer<T> eq )
		{
			return !(obj is sans0Started_._sans_.BlankI)
				&&
				Contain(
					(sans0Started_.StartedI<T, Sans0StartedI<T>>)obj
					,
					ele
					,
					eq
				);
		}

		static public bool Contain<T>(
			this nilnul.obj.str_.sans0Started_.StartedI<T, Sans0StartedI<T>> obj,T ele, IEqualityComparer<T> eq )
		{
			return eq.Equals(obj.head, ele) || Contain(obj.body, ele, eq);
			

			
		}

		

	}
}
