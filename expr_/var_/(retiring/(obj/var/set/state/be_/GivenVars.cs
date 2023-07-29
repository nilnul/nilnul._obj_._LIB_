using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.state.be_
{
	public class GivenVars<T> : BeI<T>

	{
		private nilnul.obj.var.Set<T> _vars;

		public nilnul.obj.var.Set<T> vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public GivenVars(nilnul.obj.var.Set<T> set)
		{
			_vars = set;
		}
		public bool be(State_heritDict<T> obj)
		{
			return nilnul.obj.var.set.Eq.Lazy.Equals(obj.Keys, _vars);

			//throw new NotImplementedException();
		}
	}
}
