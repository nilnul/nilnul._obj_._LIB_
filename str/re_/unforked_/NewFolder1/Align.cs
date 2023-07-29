using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.re_
{
	/// <summary>
	/// one is the other's initial segment. unforked
	/// </summary>
	public class Align<T> :
		nilnul.obj.Box1<IEqualityComparer<T>>
		,
		nilnul.objs.ReI<T>
	{
		public Align(IEqualityComparer<T> val) : base(val)
		{
		}
		public Align():this(EqualityComparer<T>.Default)
		{

		}

		/// <summary>
		/// the first is the initial segment of latter. the two could be equal
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public bool re(IEnumerable<T> a, IEnumerable<T> b)
		{
			var aEnum = a.GetEnumerator();
			var bEnum = b.GetEnumerator();

			while (aEnum.MoveNext())
			{
				if (bEnum.MoveNext())
				{
					if (!this.boxed.Equals(aEnum.Current,bEnum.Current))
					{
						return false;
					}
				}
				else
				{
					return true;
				}
			}

			return true;
			
			//throw new NotImplementedException();
		}
	}
}
