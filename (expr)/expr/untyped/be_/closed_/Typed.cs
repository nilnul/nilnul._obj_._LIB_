using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped.be_.closed_
{
	/// <summary>
	/// no vars
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Typed<T> :untyped.be_.Closed
	{
		public bool be(Untyped obj)
		{
			return  Closed.Singleton.be(obj.ee);
		}


		static public Typed<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Typed<T>>.Instance;
			}
		}

	}
}
