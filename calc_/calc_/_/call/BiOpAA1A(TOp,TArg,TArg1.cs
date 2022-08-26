using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.call
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public abstract partial class BiOpArgArg1A<TOp,TArg,TArg1>
		:nilnul.obj.op.Call_OpArgArg1A<TOp,TArg,TArg1>
	{
		public BiOpArgArg1A(TOp op,TArg arg,TArg1 arg1)
			:base(op,arg,arg1)
		{

		}

		public override string ToString()
		{
			return string.Format("{0}({1},{2})",op,arg,arg1);
		}
		
		
		
	}
}
