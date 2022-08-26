using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_.distinct.vow.ee_
{

	[Obsolete()]
	public class EqDefault<T, TEq>
		: 
		Ee<T>

		where TEq:IEqualityComparer<T>,new()

	{
		public EqDefault(ObjsI3<T> val) : base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
			,
			val
		)
		{
		}

		public EqDefault(params T[] elements):base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
			,

			elements
		)
		{

		}

		public EqDefault(IEnumerable<T> elements):base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
			,
			elements
		)
		{

		}

		
	}



}
