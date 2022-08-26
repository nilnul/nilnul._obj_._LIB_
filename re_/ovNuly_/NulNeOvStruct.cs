#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.ovNuly_
{
	
	

	public interface NulNeOvStructI<T>
		:NulNeI<T?>
		where T: struct
	{ }

	public class NulNeOvStruct<T>
		:
		nilnul.obj.Box1<IEqualityComparer<T> >
		,
		NulNeI<T?>
		where T:struct

	{
		public NulNeOvStruct(IEqualityComparer<T> val) : base(val)
		{
		}

		public bool re(T? x, T? y)
		{
			if (x is null)
			{
				if (y is null)
				{
					return false;
				}
				return false;
			}
			if (y is null)
			{
				return false;
			}
			return boxed.Equals(x.Value, y.Value);
			//throw new NotImplementedException();
		}

	
	}

}
