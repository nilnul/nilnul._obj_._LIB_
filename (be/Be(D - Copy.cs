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
	///
	[Obsolete()]
	public  class Be<D>
		:BeI<D>
	{
		private System.Func<D,bool> _func;

		public System.Func<D,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}
		
		public Be(System.Func<D,bool> func)
		{
			this.func = func;

		}
		public bool be(D d)
		{
			return func(d);
			throw new NotImplementedException();
		}
	}


}
