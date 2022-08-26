using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec_.tro.eq_
{
	public class ElEqDefault<T, TEq>
		:
		Eq<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public ElEqDefault() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance

		)
		{
		}


		static public ElEqDefault<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ElEqDefault<T, TEq>>.Instance;
			}
		}

	}
}
