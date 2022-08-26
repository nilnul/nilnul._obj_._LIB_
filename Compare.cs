using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	/// <summary>
	/// compare of something. the existance of a "comp" means the instances can be linearly ordered.
	/// Note: the linear order might put two distanct instances at the same point. So the "eq" derived from this comp regards the two instances as the same.
	/// </summary>
	/// Co match pair
	/// 
	public interface IComp {}



	public interface IComp<T> : IComp { }

	
	public abstract class CompareA<T> : IComparer<T>
		,IComp
	{
		public abstract int Compare(T x, T y)
		;

		public bool? bitNul(T x, T y) {
			var t = Compare(x, y);
			return t == 0 ? null :(bool?) (t > 0 );
		}
	}

	public class Comp<T>
		: nilnul.obj.Box1<Func<T, T, int>>
		,
		IComparer<T>
	{
		public Comp(Func<T, T, int> val) : base(val)
		{
		}

		public int Compare(T x, T y)
		{
			return boxed(x, y);
			//throw new NotImplementedException();
		}
	}
}
