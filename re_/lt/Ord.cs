using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.lt
{
	/// <summary>
	/// aka: inverse, sup,converse
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TLt"></typeparam>
	public class Ord<T, TEq, TLt> 
		:nilnul.obj.OrdI<T>

		where TLt: nilnul.obj.re_.LtI<T>,new()
		where TEq:IEqualityComparer<T>,new()
	{
		public bool ge(T a, T b)
		{
			return obj.re_.lt.gt.Ge<T, TEq, TLt>.Singleton.re(a, b);
		}
		public bool nge(T a, T b)
		{
			return obj.re_.lt.gt.ge.Not<T, TEq, TLt>.Singleton.re(a, b);
		}

		public bool gt(T a, T b)
		{
			return obj.re_.lt.Gt<T, TLt>.Singleton.re(a, b);

		}
		public bool ngt(T a, T b)
		{
			return obj.re_.lt.gt.Not<T,  TLt>.Singleton.re(a, b);
		}
		public bool le(T a, T b)
		{
			return obj.re_.lt.Le<T,TEq, TLt>.Singleton.re(a, b);

		}
		public bool nle(T a, T b)
		{
			return obj.re_.lt.le.Not<T,TEq,  TLt>.Singleton.re(a, b);
		}

		public bool lt(T a, T b)
		{
			return nilnul.obj_.Singleton<TLt>.Instance.re(a, b);

		}
		public bool nlt(T a, T b)
		{
			return obj.re_.lt.Not<T,TLt>.Singleton.re(a, b);
		}

		public bool ne(T a, T b)
		{
			return nilnul.obj.eq.Ne<T, TEq>.Singleton.ne(a, b);
		}

		public bool eq(T a, T b)
		{
			return nilnul.obj_.Singleton<TEq>.Instance.Equals(a, b);
		}
		static public Ord<T, TEq, TLt> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ord<T, TEq, TLt>>.Instance;
			}
		}


	}
}
