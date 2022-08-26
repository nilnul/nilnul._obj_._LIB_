using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{


	[Obsolete()]
	public class En2<T, TBe>
	:
	nilnul.obj.vow.En<T, nilnul.obj.be.Vow1<T,TBe>>

	where TBe : BeI<T>,new()
	{

		public En2(T val) : base(
			 val
			)
		{

		}


	}

}
