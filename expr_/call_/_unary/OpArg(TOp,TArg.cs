using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.expr_.call_._unary
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	///

	[Obsolete(nameof(obj.calc_._unary.OpArgI<TOp,TArg>))]

	public interface OpArgI<TOp, TArg>
		: nilnul.obj.expr_.call_._nary.OpI<TOp>
		,
		ArgI<TArg>
		where TOp : nilnul.obj.IOp  //to be used in higher-ord

	{




	}
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 

	[Obsolete(nameof(obj.calc_._unary.IOpArg))]
	public   class OpArg<TOp,TArg>
		: _nary.Op<TOp>
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}
		
		
		public OpArg(TOp op,TArg arg)
			:base(op)
		{
			this.arg = arg;
			
		}
	}
}
