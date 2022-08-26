using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct.vow.ee_
{
	public class EqNeo<T, TEq>
		: 
		Ee1<T>

		where TEq:IEqualityComparer<T>,new()

	{
		public EqNeo(IEnumerable<T> val)
			:
		base(
			val
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<distinct.vow_.EqNeo<T,TEq>>.Instance
		)
		{
		}

		public EqNeo(params T[] elements):this(

			(IEnumerable<T>)elements
		)
		{
		}
	}
}