using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp_
{
	/// <summary>
	/// give each element a tag, such as to order it according to the tag
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TTag"></typeparam>
	/// alias:
	///		mapped
	public class ByTag<T, TTag>
		:
		nilnul.obj.Box1<(Func<T, TTag>, IComparer<TTag>)>
		,
		IComparer<T>
	{
		public ByTag((Func<T, TTag>, IComparer<TTag>) val) : base(val)
		{
		}
		public ByTag(Func<T, TTag> func, IComparer<TTag> val) : this((func,val))
		{
		}

		public ByTag(Func<T, TTag> func) : this(func,Comparer<TTag>.Default)
		{
		}



		public int Compare(T x, T y)
		{
			return boxed.Item2.Compare( boxed.Item1(x), boxed.Item1(y) );
		}
	}
}
