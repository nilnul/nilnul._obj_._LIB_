using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.expr_.call_._binary
{

	[Obsolete(nameof(obj.calc_._binary.ArgArg1I<T,T1>))]
	public interface ArgArg1I<T,T1>
		: _unary.ArgI<T>, Arg1I<T1>
	{

	}
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TArg">the operator</typeparam>
	/// 

	[Obsolete(nameof(obj.calc_._binary.ArgArg1I<TArg,TArg1>))]
	public   class ArgArg1<TArg,TArg1>
		: _unary.Arg<TArg>
		,
		ArgArg1I<TArg,TArg1>
	{
		private TArg1 _arg1;
		public TArg1 arg1
		{
			get
			{
				return _arg1;
			}
			set
			{
				_arg1=value;
			}
		}

		

		public ArgArg1(TArg arg,TArg1 arg1)
			:base(arg)
		{
			this.arg1 = arg1;

		}
	}

	

}
