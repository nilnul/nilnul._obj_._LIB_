using nilnul.obj.op_.binary.cumulator.be_._unard.semi_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_
{


	public class Unard<T> :
		nilnul.obj.Box1<
			LeftUnardI<T>
		>,

		IRightUnard, ILeftUnard
		, RightUnardI<T>, LeftUnardI<T>
	, cumulator.Be_cumulatorGeneriI<T>
	{
		_unard.semi_.right_.ByConversing<T> rightUnard;
		public Unard(LeftUnardI<T> val) : base(val)
		{
			rightUnard = new _unard.semi_.right_.ByConversing<T>(val);
		}

		public bool be(CumulatorI<T> obj)
		{
			return boxed.be(obj) && rightUnard.be(obj);
			//throw new NotImplementedException();
		}
	}
}
