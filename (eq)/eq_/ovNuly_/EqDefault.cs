using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.eq_;

namespace nilnul.obj.eq_.ovNuly_
{


	public class EqDefault<T, TEq>
		:

		OvNuly<T>
		where TEq : IEqualityComparer<T>, new()
		where T: class?

	{
		public EqDefault() : base( nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance)
		{
		}


		static public EqDefault<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqDefault<T, TEq>>.Instance;
			}
		}

	}



}
