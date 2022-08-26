using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.unary
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TArg"></typeparam>
	public partial class Fixed<TArg,TR> : 

		nilnul.obj.op.FixedA<TR>	
		,
		nilnul.obj.op.UnaryI<TArg,TR>
	{


		public Fixed(TR val)
			:base(val)
		{
			
		}




		public TR eval(TArg a)
		{
			return val;
			throw new NotImplementedException();
		}
	}

}
