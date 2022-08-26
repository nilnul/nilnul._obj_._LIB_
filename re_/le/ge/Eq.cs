using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.le.ge
{
	/// <summary>
	/// aka: inverse, sup
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TLe"></typeparam>
	public class Eq<T,  TLe> :
		ReI<T>
		where TLe: nilnul.obj.re_.LeI<T>,new()
	{
		public bool re(T a, T b)
		{
			return nilnul.obj_.Singleton<TLe>.Instance.re(a,b) &&  le.Ge<T, TLe>.Singleton.re(a, b) ;
		}
		static public Eq<T, TLe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq<T, TLe>>.Instance;
			}
		}
	}
}
