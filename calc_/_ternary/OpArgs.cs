using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.calc_._ternary
{


	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public interface OpArgsI<TOp, TArg, TArg1>
		: nilnul.obj.calc_._binary.OpArgArg1I<TOp, TArg, TArg1>
		,
		Arg2I<TArg1>
		where TOp : nilnul.obj.IOp  //to be used in higher-ord

	{




	}
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public class OpArgs<TOp, TArg, TArg1, TArg2>
			: nilnul.obj.calc_._binary.OpArgArg1<TOp, TArg, TArg1>

	{
		private TArg2 _arg2;

		public TArg2 arg2
		{
			get { return _arg2; }
			set { _arg2 = value; }
		}
		public OpArgs(TOp op, TArg arg, TArg1 arg1, TArg2 arg2)
			: base(op, arg, arg1)
		{
			this._arg2 = arg2;

		}




	}
	public class OpArgs<TOp, TArg>
		:
		OpArgs<TOp, TArg, TArg, TArg>

	{
		public OpArgs(TOp op, TArg arg, TArg arg1, TArg arg2) : base(op, arg, arg1, arg2)
		{
		}
	}


}
