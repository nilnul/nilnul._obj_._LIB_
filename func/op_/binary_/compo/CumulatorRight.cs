using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.obj.FuncI3;


namespace nilnul.obj.func.op_.binary_.compo
{
	/// <summary>
	/// 
	/// </summary>
	public class CumulatorRight
		: nilnul.obj.op_.binary.cumulator_.OpDefault4Right<F, binary_.CompoLeft2right>
		,
		nilnul.obj.op_.binary.cumulator_.IRightUnardable
	{
		public CumulatorRight() : base(
			func_.uni_.closed_.generi_.Nop.Singleton //.ee.ee.ee
		)
		{

		}
	}
}
