using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comparer
{
	/// <summary>
	/// comparer defined a relation that is total, linear order.
	/// Converse of such relation means 
	/// </summary>
	public class Converse<T> :
		nilnul.obj.Box1<IComparer<T>>
		,
		IComparer<T>
	{
		public Converse(IComparer<T> val) : base(val)
		{
		}
		public Converse():base(Comparer<T>.Default)
		{

		}

		/// <summary>
		/// converse is same as negative as long as the comparer is defined to be a linear order
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare(T x, T y)
		{
			return boxed.Compare(y,x);
		}
	}
}
