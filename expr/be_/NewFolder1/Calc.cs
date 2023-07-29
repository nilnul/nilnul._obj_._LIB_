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
	[Obsolete()]
	public class Calc<T> : expr.BeI<T>
	{
		public bool be(ExprI_sys<T> obj)
		{
			return _expr.untyped.be_.Calc.Singleton.be(obj.untyped.ee);
			
			//throw new NotImplementedException();
		}

		static public Calc<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Calc<T>>.Instance;
			}
		}

	}
}
