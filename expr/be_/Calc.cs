using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be_
{
	/// <summary>
	/// no vars
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	public class Calc : expr.BeI
	{
		public bool be(obj.ExprI4 obj)
		{
			var v = new _calc.lamda.Visitor();
			v.Visit(obj.expr.ee);
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
