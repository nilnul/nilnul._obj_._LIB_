using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._sortie_
{
	[Obsolete()]
	public interface AsDistinct<T>
	{
		nilnul.objs.be_.distinct.vow.En1<T> asDistinct { get; }
	}

	[Obsolete()]
	public interface AsDistinct<T, TEq>
		where TEq:IEqualityComparer<T>, new()
	{
		nilnul.objs.be_.distinct.vow.En1<T, TEq> asDistinct { get; }
	}
}
