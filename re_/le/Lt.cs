using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.le
{
	/// <summary>
	/// aka: inverse, sup
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TLe"></typeparam>
	public class Lt<T,  TLe> :
		ReI<T>
		where TLe: nilnul.obj.re_.LeI<T>,new()
	{

		public bool re(T a, T b)
		{
			return nilnul.obj_.Singleton<TLe>.Instance.re(a, b)  && ge.eq.Not<T,TLe>.Singleton.re(a,b);
		}

		static public Lt<T, TLe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Lt<T, TLe>>.Instance;
			}
		}

	}
}
