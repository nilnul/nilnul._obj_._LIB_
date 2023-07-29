using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.calc_._ternary
{

	public interface ArgsI<T,T1,T2>
		: _binary.ArgArg1I<T,T1>, Arg2I<T2>
	{

	}
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TArg">the operator</typeparam>
	/// 

	public   class Args<TArg,TArg1,TArg2>
		: _binary.ArgArg1<TArg,TArg1>
		,
		ArgsI<TArg,TArg1,TArg2>
	{
		private TArg2 _arg2;
		public TArg2 arg2
		{
			get
			{
				return _arg2;
			}
			set
			{
				_arg2=value;
			}
		}

		

		public Args(TArg arg,TArg1 arg1,TArg2 arg2)
			:base(arg,arg1)
		{
			this.arg2 = arg2;

		}
	}

	

}
