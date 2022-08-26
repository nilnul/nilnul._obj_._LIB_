using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.be.vow_
{
	public class BeNeo<T, TBe>
		:
		be.Vow<T>
		where TBe : str.strung.BeI<T>, new()
	{
		public BeNeo() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance

			)
		{
		}


		static public BeNeo<T, TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeNeo<T, TBe>>.Instance;
			}
		}

	}
}
