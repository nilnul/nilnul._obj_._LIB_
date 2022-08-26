using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.lt.le
{

	public class Ge<T, TEq, TLt> : re.Converse<T, re_.lt.Le<T,TEq,TLt>>
		where TLt: nilnul.obj.re_.LtI<T>,new()
		where TEq:IEqualityComparer<T>,new()
	{

		static public Ge<T, TEq, TLt> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ge<T,TEq, TLt>>.Instance;
			}
		}

	}
}
