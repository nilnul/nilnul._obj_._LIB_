using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.lt
{
	/// <summary>
	/// aka: inverse, sup,converse
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TLt"></typeparam>
	public class Gt<T, TLt> : re.Converse<T, TLt>
		where TLt: nilnul.obj.re_.LtI<T>,new()
	{


		static public Gt<T, TLt> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Gt<T, TLt>>.Instance;
			}
		}

	}
}
