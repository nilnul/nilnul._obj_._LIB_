using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.op_
{
	public interface IOf:IOp
	{
	}
	public interface IOf<T> : IOf, IOp<T> { }

	public interface OfI<T, TSrc> :
		IOf<T>
		,
		nilnul.obj.op_.OfI1<IEnumerable<IEnumerable<T>>, TSrc>
	{ }
}
