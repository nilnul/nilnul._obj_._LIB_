using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.re_
{
	public class Dif : nilnul.obj.var.ReI
	{
		public bool re(VarI1 x, VarI1 y)
		{
			return nilnul.obj.var.Eq1.Instance.Equals(x, y);

			//throw new NotImplementedException();
		}


		static private Lazy<Dif> _Lazy = new Lazy<Dif>();
		static public Dif Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
