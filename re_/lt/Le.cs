using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.lt
{
	/// <summary>
	/// aka: inverse, sup
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TLt"></typeparam>
	public class Le<T, TEq, TLt> :
		nilnul.obj.re_.LeI<T>,
		ReI<T>
		where TEq:IEqualityComparer<T>,new()
		where TLt: nilnul.obj.re_.LtI<T>,new()
	{

		public bool re(T a, T b)
		{
			return nilnul.obj_.Singleton<TLt>.Instance.re(a, b)  || nilnul.obj_.Singleton<TEq>.Instance.Equals(a,b);
		}

		static public Le<T, TEq,TLt> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Le<T,TEq, TLt>>.Instance;
			}
		}

	}
}
