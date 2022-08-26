using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_
{


	public class Nilard<T> :
		nilnul.obj.Box1<
			_nilard.semi_.LeftNilardI<T>
		>
		,
		 _nilard.semi_.LeftNilardI<T>
		,
		_nilard.semi_.RightNilardI<T>
	, cumulator.be_.NilardableI<T>
	{
		_nilard.semi_.right_.ByConversing<T> _rightNilard;
		public Nilard(_nilard.semi_.LeftNilardI<T> val) : base(val)
		{
			_rightNilard = new _nilard.semi_.right_.ByConversing<T>(val);
		}

		public bool be(CumulatorI<T> obj)
		{
			return boxed.be(obj) && _rightNilard.be(obj);
			//throw new NotImplementedException();
		}
	}
}
