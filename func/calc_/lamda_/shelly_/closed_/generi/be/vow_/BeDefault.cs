using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.closed_.generi.be.vow_
{
	public class BeDefault<TRet, TBe>
		:
		Vow<TRet>
		where TBe : nilnul.obj.BeI1<func.calc_.lamda_.closed_.Generi<TRet>>, new()
	{
		public BeDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance)
		{
		}


		static public BeDefault<TRet, TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<TRet, TBe>>.Instance;
			}
		}

	}
}
