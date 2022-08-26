using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.be_
{
	/// <summary>
	/// take the return type as the type for comparision.
	/// the type of input shall be subtype of return type
	/// </summary>
	public class Closed
		: func.BeI
	{
		

		public bool _be_assumeFlat(LambdaExpression obj)
		{

			return  obj.Parameters.All(
				p=>p.Type ==obj.ReturnType
			);
			//throw new NotImplementedException();


		}

		public bool be(FuncI3 obj)
		{
			return _be_assumeFlat(obj.flat);
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
