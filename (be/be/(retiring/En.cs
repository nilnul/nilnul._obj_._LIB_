using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	

	[Obsolete()]
	public class En1<T> :
		nilnul.obj.vow.En<T>
		,
		
		EnI1<T>
	{
		public En1(BeI<T> be, T val):base(
			new nilnul.obj.be.Vow<T>(be)
			, 
			val

		)
		{

		}
		
	}
}
