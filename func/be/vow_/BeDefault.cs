using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.obj.FuncI3;


namespace nilnul.obj.func.be.vow_
{
	public class BeDefault< TBe>
		:
		Vow
		where TBe : nilnul.obj.BeI1<F>, new()
	{
		public BeDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance)
		{
		}


		static public BeDefault< TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault< TBe>>.Instance;
			}
		}

	}
}
