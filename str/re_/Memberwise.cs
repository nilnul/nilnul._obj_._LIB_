using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.re_
{
	/// <summary>
	/// one is the other's initial segment. unforked
	/// </summary>
	/// alias:
	///		align
	///		compatible
	///		unforked
	///		
	public class Memberwise<T>
		:
		nilnul.obj.Box1<obj.ReI<T>>
		,
		nilnul.objs.ReI<T>
		,
		nilnul.obj.str_.seq.ReI<T>
		,
		nilnul.obj.str_.seq.ReOfEnumeratorI<T>
	{
		public Memberwise(obj.ReI<T> val) : base(val)
		{
		}
		public bool re(IEnumerator<T> aEnum, IEnumerator<T> bEnum)
		{

			while (aEnum.MoveNext())
			{
				if (bEnum.MoveNext())
				{
					if (!this.boxed.re(aEnum.Current,bEnum.Current))
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}

			return !bEnum.MoveNext();
		}
	

		/// <summary>
		/// the first is the initial segment of latter. the two could be equal
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool re(IEnumerable<T> a, IEnumerable<T> b)
		{

			return re(
				a.GetEnumerator()
				,
				b.GetEnumerator()
			);
		}


	}
}
