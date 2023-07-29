using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.set.re_.sub_
{
	public class ElEqDefault<T, TEq>
		:
		re_.Sub<T>
		,
		nilnul.obj.ReI<IEnumerable<T>>
		where TEq : IEqualityComparer<T>, new()
	{
		public ElEqDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance)
		{
		}



		static public ElEqDefault<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<ElEqDefault<T, TEq>>.Instance;
			}
		}


	}

}

