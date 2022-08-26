using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.en_
{

	public class BeDefaulted2<T, TBe>
	:
	obj.be.En4<T>

	where TBe : nilnul.obj.BeI1<T>,new()
	{

		public BeDefaulted2(T val) : base(
			 val,nilnul.obj_.Singleton<TBe>.Instance
			)
		{

		}


	}
	
}
