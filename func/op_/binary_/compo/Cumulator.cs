using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.op_.binary_.compo
{
	/// <summary>
	/// 
	/// </summary>
	public class Cumulator
		: nilnul.obj.op_.binary.cumulator_.OpDefault<obj.FuncI3, binary_.CompoLeft2right>
	#region if the par in the fist func is of the same type as the first par of the second func. LambdaExpression par's static type is of object; but there are dynamic type checking which might throw exception.  So this is not type safe in contrast to CumulatorRight
		//,
		//nilnul.obj.op_.binary.cumulator_.IUnardable 

	#endregion
	{
		public Cumulator( ) : base(func_.uni_.closed_.generi_.Nop.Singleton)
		{

		}
	}
}
