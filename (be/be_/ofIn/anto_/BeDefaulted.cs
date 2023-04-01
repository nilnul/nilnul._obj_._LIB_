using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be_.ofIn.anto_
{


	public class BeDefaulted<T, TBe> :

		nilnul.obj.be_.ofIn.Anto<T>

		where TBe : nilnul.obj.BeI_ofIn<T>, new()
	{
		public BeDefaulted() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}

		static public BeDefaulted<T, TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefaulted<T, TBe>>.Instance;
			}
		}
	}
}