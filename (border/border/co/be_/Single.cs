using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co.be_
{
	public class Single<T,TBorder> :
		BeA<T,TBorder>
		where TBorder: obj.BorderI<T>
	{
		private IEqualityComparer<T> _elEq;

		public IEqualityComparer<T> elEq
		{
			get { return _elEq; }
			set { _elEq = value; }
		}

		public Single(IEqualityComparer<T> elEq)
		{
			_elEq = elEq;
		}
		public override bool be(in (TBorder,TBorder) obj)
		{
			return _elEq.Equals( obj.Item1.mark , obj.Item2.mark)
				&&
				obj.Item1.openFalseCloseTrue && obj.Item2.openFalseCloseTrue;
		}


		


	}
}
