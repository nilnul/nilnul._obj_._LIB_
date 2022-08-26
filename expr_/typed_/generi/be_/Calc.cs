using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi.be_
{
	/// <summary>
	/// no vars
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	public class Calc<T> : BeI<T>
	{
		public bool be(GeneriI<T> obj)
		{
			return expr.be_.Calc.Singleton.be(obj);
			
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
