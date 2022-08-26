using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.unary
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TR"></typeparam>
	public partial class Const<TR,TArg> : 

		nilnul.obj.op.Const<TR>
		
	{
		

		public Const(TR val)
			:base(val)
		{
			
		}
	



		public TR eval(TArg x)
		{
			return val;
		}

	


	}

}
