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
	public partial class Call<TArg, TArg1, R, TOp>
		:
		_tuple._call.ArgArg1A<TArg, TArg1>
		,nilnul.obj._tuple._call.OpI<TOp>
		,nilnul.obj._tuple._call.EvalI<R>

		where TOp : duo.op.OpI<TArg, TArg1, R>



	{
		private TOp _op;

		public TOp op
		{
			get { return _op; }
			set { _op = value; }
		}



		public Call(TOp op, TArg arg, TArg1 arg1)
			:base (arg,arg1)
		{
			_op = op;

		}

		public R eval()
		{
			return _op.eval(arg, arg1);
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{_op.ToString()}({this.arg.ToString()},{this.arg1.ToString()})";
        }
	}

}
