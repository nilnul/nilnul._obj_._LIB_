using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.assign.re_
{
	public class DiffVar<T> : assign.ReI<T>
	{
		public bool re(Assignment<T> x, Assignment<T> y)
		{
			return nilnul.obj.var.re_.Dif.Lazy.re(x.var, y.var);

			//throw new NotImplementedException();
		}
	}
}
