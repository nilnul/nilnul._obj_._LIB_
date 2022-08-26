using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.unary
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TArg"></typeparam>
	public partial class Fixed<TArg,TArg2,TR> : 

		nilnul.obj.op.FixedA<TR>	
		,
		nilnul.obj.op.BinaryI<TArg,TArg2,TR>
	{


		public Fixed(TR val)
			:base(val)
		{
			
		}




		

		public TR eval(TArg a, TArg2 b)
		{
				return val;
		throw new NotImplementedException();
		}
	}

}
