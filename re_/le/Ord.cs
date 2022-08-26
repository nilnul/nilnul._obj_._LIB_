using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.le
{
	/// <summary>
	/// aka: inverse, sup,converse
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TLe"></typeparam>
	public class Ord<T,  TLe> 
		:nilnul.obj.OrdI<T>
		

		where TLe: nilnul.obj.re_.LeI<T>,new()
	{
		public bool ge(T a, T b)
		{
			return obj.re_.le.Ge<T, TLe>.Singleton.re(a, b);
		}

		public bool nge(T a, T b)
		{
			return obj.re_.le.ge.Not<T, TLe>.Singleton.re(a, b);
		}

		public bool gt(T a, T b)
		{
			return obj.re_.le.ge.Gt<T, TLe>.Singleton.re(a, b);

		}
		public bool ngt(T a, T b)
		{
			return obj.re_.le.ge.gt.Not<T, TLe>.Singleton.re(a, b);
		}

		public bool lt(T a, T b)
		{
			return obj.re_.le.Lt<T, TLe>.Singleton.re(a, b);

		}
		public bool nlt(T a, T b)
		{
			return obj.re_.le.lt.Not<T, TLe>.Singleton.re(a, b);
		}

		public bool le(T a, T b)
		{
			return nilnul.obj_.Singleton<TLe>.Instance.re(a, b);

		}
		public bool nle(T a, T b)
		{
			return obj.re_.le.Not<T, TLe>.Singleton.re(a, b);
		}

		public bool ne(T a, T b)
		{
			return nilnul.obj.re_.le.ge.eq.Not<T, TLe>.Singleton.re(a, b);
		}

		public bool eq(T a, T b)
		{
			return nilnul.obj.re_.le.ge.Eq<T,TLe>.Singleton.re(a, b);
		}
		static public Ord<T,  TLe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ord<T,  TLe>>.Instance;
			}
		}


	}
}
