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
	[Obsolete(nameof(expr_.typed_.generi.be_.Closed<T>))]
	public class Closed<T> : expr.BeI<T>
	{
		public bool be(ExprI_sys<T> obj)
		{
			return _expr.untyped.be_.Closed.Singleton.be(obj.untyped.ee);
			
			//throw new NotImplementedException();
		}

		static public Closed<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Closed<T>>.Instance;
			}
		}

	}
}
