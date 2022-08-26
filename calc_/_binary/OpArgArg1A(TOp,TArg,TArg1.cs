using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.calc_._binary
{


	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	/// 
	public interface OpArgArg1I<TOp, TArg, TArg1>
		: nilnul.obj.calc_._unary.OpArgI<TOp, TArg>
		,
		Arg1I<TArg1>
		where TOp : nilnul.obj.IOp  //to be used in higher-ord

	{




	}
/// <summary>
/// 
/// </summary>
/// <typeparam name="TOp">the operator</typeparam>
/// 
public class OpArgArg1<TOp,TArg,TArg1>
		: nilnul.obj.calc_._unary.OpArg<TOp,TArg>

	{
		private TArg1 _arg1;

		public TArg1 arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}
		public OpArgArg1(TOp op,TArg arg,TArg1 arg1)
			:base(op,arg)
		{
			this._arg1 = arg1;

		}
		
		
		
	}
}
