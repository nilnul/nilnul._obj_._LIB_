using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// a unary relation.
	/// </summary>
	/// <typeparam name="D"></typeparam>
	public class Be1<D>
		:BeI<D>
		,nilnul.obj.BeI1<D>
	{
		private System.Func<D,bool> _func;

		public System.Func<D,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}
		
		public Be1(System.Func<D,bool> func)
		{
			this._func = func;
		}

		public Be1(Predicate<D> predicate)
		{
			this._func = x=> predicate(x);
		}
		public bool be(D d)
		{
			return func(d);
		}
	}


}
