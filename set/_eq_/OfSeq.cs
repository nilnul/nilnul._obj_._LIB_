using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set._eq_
{


	public static  class  _OfSeqX
	{

		static public bool Eq<T>(IEnumerable<T> x, IEnumerable<T> y, IEqualityComparer<T> elementEq)
		{
			return set.re_._Subset.Subset(x, y, elementEq) && set.re_._Subset.Subset(y, x, elementEq);
		}

		static public bool Eq<T,TEq>(IEnumerable<T> x, IEnumerable<T> y)
			where TEq:IEqualityComparer<T>,new()
		{
			return Eq<T>(x,y, nilnul.obj_.Singleton<TEq>.Instance);
		}

	}
	public class OfSeq<T> :
		nilnul.obj._set_.MemberEqA<T>
		,
		IEqualityComparer<
		IEnumerable<T>
	>
	{
		

		private nilnul.obj.set.re_.SubsetBetweenEnumerables<T> _subset;

		public nilnul.obj.set.re_.SubsetBetweenEnumerables<T> subset
		{
			get { return _subset; }
		//	set { _subset = value; }
		}


		public OfSeq(
			IEqualityComparer<T> elementEq
		):base(elementEq)
		{
			_subset = new re_.SubsetBetweenEnumerables<T>(elementEq);
		}
		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{
			return _subset.re(x, y) && _subset.re(y, x);

			//throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<T> obj)
		{
			return 0;
		//	throw new NotImplementedException();
		}
	}
}
