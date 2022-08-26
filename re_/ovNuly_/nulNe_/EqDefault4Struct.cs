using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.eq_;

namespace nilnul.obj.re_.ovNuly_.nulNe_
{


	public class EqDefault4Struct<T, TEq>
		:

		NulNeOvStruct<T>
		where TEq : IEqualityComparer<T>, new()
		where T:struct

	{
		public EqDefault4Struct() : base( nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance)
		{
		}


		static public EqDefault4Struct<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqDefault4Struct<T, TEq>>.Instance;
			}
		}

	}



}
