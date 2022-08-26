using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.lt.gt
{
	/// <summary>
	/// aka: inverse, sup
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TLt"></typeparam>
	public class Ge<T, TEq, TLt> :
		ReI<T>
		where TEq:IEqualityComparer<T>,new()
		where TLt: nilnul.obj.re_.LtI<T>,new()
	{
		public bool re(T a, T b)
		{
			return lt.Gt<T, TLt>.Singleton.re(a, b)  || nilnul.obj_.Singleton<TEq>.Instance.Equals(a,b);
		}
		static public Ge<T, TEq,TLt> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ge<T,TEq, TLt>>.Instance;
			}
		}
	}
}
