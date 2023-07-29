using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo
{

	/// <summary>
	/// 
	/// </summary>
	/// 
	///morphism fro A to R
	public partial class CallA<TOp, TArg, TArg1>
		:
		_tuple._call.ArgArg1A<TArg, TArg1>
	{
		private TOp _op;

		public TOp op
		{
			get { return _op; }
			set { _op = value; }
		}



		public CallA(TOp op, TArg arg, TArg1 arg1)
			:base (arg,arg1)
		{
			_op = op;

		}

	
	}

}
