using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.op_
{

	[Obsolete(nameof(strung.IOf))]
	public interface IOf:IOp
	{
	}
	[Obsolete(nameof(strung.IOf))]
	public interface IOf<T> : IOf, IOp<T> { }

	[Obsolete(nameof(strung.IOf))]
	public interface OfI<T, TSrc> :
		IOf<T>
		,
		nilnul.obj.op_.OfI1<IEnumerable<IEnumerable<T>>, TSrc>
	{ }
}
