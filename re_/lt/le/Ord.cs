using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.lt.le
{
	/// <summary>
	/// aka: inverse, sup,converse
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TLt"></typeparam>
	public class Ord<T, TEq, TLt> 
		:
		nilnul.obj.re_.le.Ord<T,  lt.Le<T,TEq,TLt>  >
		,
		nilnul.obj.OrdI<T>

		where TLt: nilnul.obj.re_.LtI<T>,new()
		where TEq:IEqualityComparer<T>,new()
	{
		
		static public Ord<T, TEq, TLt> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ord<T, TEq, TLt>>.Instance;
			}
		}


	}
}
