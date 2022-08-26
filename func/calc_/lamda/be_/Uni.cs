using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Uni
		: func.calc_.lamda.BeI
	{
		
		public bool be(LambdaExpression obj)
		{
			return obj.Parameters.Count == 1;

		}

		static public Uni Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Uni>.Instance;
			}
		}

	}
}
