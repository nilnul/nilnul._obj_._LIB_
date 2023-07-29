using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung
{
	public interface IOf:obj.IOf1<str.IStrung>
	{
	}
	public interface IOf<TEl> : IOf, obj. IOf1<str.IStrung<TEl>> { }

	public interface OfI<TEl, TSrc> :
		IOf<TEl>
		,
		nilnul.obj.OfI1<IEnumerable<IEnumerable<TEl>>, TSrc>
	{ }
}
