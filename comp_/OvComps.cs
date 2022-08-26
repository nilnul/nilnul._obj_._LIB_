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
	public class OvComps<T>
		:
		nilnul.obj.Box1<
			IEnumerable< IComparer<T>>
		>
		,
		IComparer<T>
	{
		public OvComps(IEnumerable< IComparer<T>> val) : base(val)
		{
		}
		
		public OvComps(params IComparer<T>[] val) : this((IEnumerable< IComparer<T>>) val)
		{
		}


		public int Compare(T x, T y)
		{
			var r = 0;
			foreach (var item in boxed)
			{
				r = item.Compare(x, y);
				if (r!=0)
				{
					break;
				}
			}

			return r;
		}
	}
}
