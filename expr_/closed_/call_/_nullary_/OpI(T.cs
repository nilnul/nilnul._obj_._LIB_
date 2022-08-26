using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.call_._nullary_
{
	

	public abstract class OpA<TResultOfOp,TOp> : nilnul.obj.expr_._call_.OpA<TOp>
		where TOp:nilnul.obj.Constant<TResultOfOp>
	{

		public OpA(TResultOfOp op)
		{
			_op = new TOp() ;
		}



		private TOp _op;
		public TOp op
		{
			set
			{
				_op = value;
			}
			get
			{
				return _op;
				//throw new NotImplementedException();
			}
		}
	}

}
