using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.eq
{
	public class Not<T, TEq>
		:
		re.complement_.ReDefault<T, TEq>
		where TEq: nilnul.obj.re_.EqI<T>,new()
	{



		static public Not<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Not<T, TEq>>.Instance;
			}
		}


	}
}
