using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.le
{
	/// <summary>
	/// aka: inverse, sup,converse
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOrd"></typeparam>
	public class Ge<T, TOrd> : re.Converse<T, TOrd>
		where TOrd: nilnul.obj.re_.LeI<T>,new()
	{


		static public Ge<T, TOrd> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ge<T, TOrd>>.Instance;
			}
		}

	}
}
