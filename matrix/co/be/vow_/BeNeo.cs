using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.co.be.vow_
{
	public class BeNeo<T, TBe>
		:
		matrix.co.be.Vow<T>

		where TBe : nilnul.obj.BeI_ofIn<(T[,],T[,])>, new()
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
