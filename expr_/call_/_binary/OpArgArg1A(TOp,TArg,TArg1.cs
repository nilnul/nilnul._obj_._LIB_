using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.expr_.call_._binary
{


	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public interface OpArgArg1I<TOp, TArg, TArg1>
		: nilnul.obj.expr_.call_._unary.OpArgI<TOp, TArg>
		,
		Arg1I<TArg1>
		where TOp : nilnul.obj.IOp  //to be used in higher-ord

	{




	}

	public interface OpArgArg1I<TOp, TArg>
		: 
		
		OpArgArg1I<TOp,TArg,TArg>
		where TOp : nilnul.obj.IOp  //to be used in higher-ord

	{




	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public class OpArgArg1<TOp, TArg, TArg1>
			: nilnul.obj.expr_.call_._unary.OpArg<TOp, TArg>

	{
		private TArg1 _arg1;

		public TArg1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}
		public OpArgArg1(TOp op, TArg arg, TArg1 arg1)
			: base(op, arg)
		{
			this._arg1 = arg1;

		}

	}

	public class OpArgArg1<TOp, TArg> : OpArgArg1<TOp, TArg, TArg>
	{
		public OpArgArg1(TOp op, TArg arg, TArg arg1) : base(op, arg, arg1)
		{
		}
	}
}
