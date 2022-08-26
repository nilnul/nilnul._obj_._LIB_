using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be.vow_
{
	public class BeNeo<T, TBe>
		:
		nilnul.obj.str.be.Vow1<T>
		where TBe : nilnul.obj.str.BeI3<T>, new()
	{
		public BeNeo() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.Singleton<TBe>.Instance

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
