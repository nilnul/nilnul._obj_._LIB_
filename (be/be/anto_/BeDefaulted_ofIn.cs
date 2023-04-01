using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.anto_
{


	public class BeDefaulted_ofIn<T, TBe> :

		nilnul.obj.be.Anto_ofIn<T>

		where TBe : nilnul.obj.BeI_ofIn<T>, new()
	{
		public BeDefaulted_ofIn() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{

		}


		static public BeDefaulted_ofIn<T,TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefaulted_ofIn<T,TBe>>.Instance;
			}
		}

		

	}
}
