using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.en_
{

	[Obsolete()]
	public class BeDefaulted1<T, TBe>
	:
	obj.be.En3<T,TBe>

	where TBe : nilnul.obj.BeI1<T>,new()
	{

		public BeDefaulted1(T val) : base(
			 val,nilnul.obj_.Singleton<TBe>.Instance
			)
		{

		}


	}
	
}
