using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped.be_
{
	/// <summary>
	/// no vars
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Calc : _expr.untyped.BeI
	{
		public bool be(UntypedI obj)
		{
			
			var v = new _calc.lambda.Visitor();
			v.Visit(obj.lambda.ee);
			return v.hasNoPar;
			//throw new NotImplementedException();
		}


		static public Calc Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Calc>.Instance;
			}
		}

	}
}
