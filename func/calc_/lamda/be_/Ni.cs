using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda.be_
{
	/// <summary>
	/// the body might be a lambda and has some pars. don't use this for calc, as calc is defined as func.op.call.
	/// </summary>
	public class NivariateAtShell
		: func.calc_.lamda.BeI
	{
		
		public bool be(LambdaExpression obj)
		{
			return obj.Parameters.Count == 0;

		}

		static public NivariateAtShell Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NivariateAtShell>.Instance;
			}
		}

	}
}
