using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.lt
{
	public class Not<T, TLt> : re.Complement<T, TLt>
		where TLt: nilnul.obj.re_.LtI<T>,new()
	{


		static public Not<T, TLt> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Not<T, TLt>>.Instance;
			}
		}

	}
}
