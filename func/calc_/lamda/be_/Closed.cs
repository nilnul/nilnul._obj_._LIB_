using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda.be_
{
	/// <summary>
	/// take the return type as the type for comparision.
	/// the type of input shall be subtype of return type
	/// </summary>
	///
	[Obsolete("this is not well defined. as the body might be lambda, and compare that type to par  and we make no sense. this is only meaningful for one level func")]
	public class Closed
		: func.calc_.lamda.BeI
	{
		

		public bool be(LambdaExpression obj)
		{

			return  obj.Parameters.All(
				p=>p.Type ==obj.ReturnType
			);
			//throw new NotImplementedException();


		}

		static public Closed Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Closed>.Instance;
			}
		}

	}
}
