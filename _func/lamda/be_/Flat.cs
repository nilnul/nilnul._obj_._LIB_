using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func.lamda.be_
{
	/// <summary>
	/// body is not lambda anymore.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Flat : _func.lamda.BeI
	{
		public bool be(LambdaExpression obj)
		{
			
			return !(obj.Body is System.Linq.Expressions.LambdaExpression );
			//throw new NotImplementedException();
		}



		static public Flat Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Flat>.Instance;
			}
		}


	}
}
