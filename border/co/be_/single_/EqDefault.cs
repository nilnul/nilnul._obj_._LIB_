using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co.be_.single_
{
	public class EqDefault<T,TBorder,TEq> :
		Single<T,TBorder>
		where TBorder: obj.BorderI<T>
		where TEq:IEqualityComparer<T>,new()
	{
		

		public EqDefault()
			:base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance

		)
		{
		}



		static public EqDefault<T,TBorder,TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqDefault<T,TBorder,TEq>>.Instance;
			}
		}



	}
}
