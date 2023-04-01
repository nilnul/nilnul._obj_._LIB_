using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border
{
	public class Eq<T, 
		//TEq, 
		TBorder>
		: IEqualityComparer<TBorder>
	//	where TEq : IEqualityComparer<T>
		where TBorder : BorderI<T>
	{
		private IEqualityComparer<T> _markEq;

		public IEqualityComparer<T> markEq
		{
			get { return _markEq; }
			set { _markEq = value; }
		}

		public Eq(IEqualityComparer<T> markEq)
		{
			_markEq = markEq;
		}

		public bool Equals(TBorder x, TBorder y)
		{
			return _markEq.Equals(x.mark, y.mark) && x.openFalseCloseTrue == y.openFalseCloseTrue;
			throw new NotImplementedException();
		}

		public int GetHashCode(TBorder obj)
		{
			return obj.openFalseCloseTrue.GetHashCode() ^ _markEq.GetHashCode( obj.mark);
			throw new NotImplementedException();
		}
	}



}
