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
	public class Closed<T> : expr_.typed_.generi.BeI<T>
	{
		public bool be(GeneriI<T> obj)
		{
			return nilnul.obj.expr.be_.Closed.Singleton.be(obj);
			
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
