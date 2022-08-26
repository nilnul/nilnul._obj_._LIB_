using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj.call_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOp">the operator</typeparam>
	public abstract  class Binary<TOp,TArg,TArg1>
		:nilnul.obj.call_._binary_.OpArgArg1A<TOp,TArg,TArg1>
		where TOp:nilnul.obj.op_._binary_.BlankI
	{
		
		
		
		public Binary(TOp op,TArg arg,TArg1 arg1)
			:base(op,arg,arg1)
		{ 
			
		}

		public override string ToString()
		{
			
			return $"({arg.ToString()}){op.ToString()}({arg1})";
		}
	}



	
}
