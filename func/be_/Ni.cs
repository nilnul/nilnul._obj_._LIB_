using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Nivariate
		: func.BeI
	{
		
		public bool _be_assumeFlat(LambdaExpression obj)
		{
			return obj.Parameters.Count == 0;

		}

		public bool be(FuncI3 obj)
		{
			return _be_assumeFlat(obj.flat);
			throw new NotImplementedException();
		}

		static public Nivariate Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Nivariate>.Instance;
			}
		}

	}
}
