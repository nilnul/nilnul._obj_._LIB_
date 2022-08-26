using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct.vow_
{
	public class EqNeo<TObj, TEq>
		: obj.str.be_.distinct.Vow2<TObj>

		where TEq : IEqualityComparer<TObj>, new()
	{
		public EqNeo() : base(
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
		)
		{
		}

		public EqNeo(IEqualityComparer<TObj> equalityComparer) : base(equalityComparer)
		{
		}

		static public EqNeo<TObj, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<EqNeo<TObj, TEq>>.Instance;
			}
		}
	}
}