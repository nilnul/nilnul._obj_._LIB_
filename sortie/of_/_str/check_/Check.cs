using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.sortie.op_.of_._str.check_
{
	public class EqDefault<T,TEq>
	:
		Check<
		T
	>
		where TEq:IEqualityComparer<T>,new()
	{
		public EqDefault() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
			)
		{
		}


		static public new EqDefault<T,TEq> Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<EqDefault<T,TEq>>.Instance;
			}
		}
		static public new EqDefault<T,TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqDefault<T,TEq>>.Instance;
			}
		}


	}
}
