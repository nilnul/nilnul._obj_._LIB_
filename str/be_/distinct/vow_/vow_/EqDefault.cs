using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_.distinct.vow_
{
	[Obsolete()]
	public class EqDefault<TObj, TEq>
		: objs.be_.distinct.Vow_ovObj<TObj>

		where TEq : IEqualityComparer<TObj>, new()
	{
		public EqDefault() : base(
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
		)
		{
		}


		static public EqDefault<TObj, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqDefault<TObj, TEq>>.Instance;
			}
		}

	}
}
