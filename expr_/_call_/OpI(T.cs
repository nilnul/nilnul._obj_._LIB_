using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_._call_
{
	public interface OpI<TOp>
	{
		TOp op { get; }
	}

	public abstract class OpA<TOp> : OpI
	{

		public OpA(TOp op)
		{
			_op = op;
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
