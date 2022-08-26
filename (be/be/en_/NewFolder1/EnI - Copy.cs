using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.en_
{

	[Obsolete()]
	public class BeDefaultable<T, TBe>
	:
	obj.be.En<T,TBe>

	where TBe : nilnul.obj.BeI1<T>,new()
	{

		public BeDefaultable(T val) : base(
			 val,nilnul.obj_.Singleton<TBe>.Instance
			)
		{

		}


	}
	
}
