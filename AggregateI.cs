using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// Ts --> T
	/// </summary>
	///
	[Obsolete(nameof(_aggregate_.BlankI))]
	public interface AggregateI
	{
	}
	/// <summary>
	/// Ts ---> T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete()]
	public interface AggregateI<T>
	{
		T aggregate(nilnul.ObjsI2<T> objs);
	}

	public interface AggregateI1<T>
		:_aggregate_.OfSetI<T>
		,
		_aggregate_.BlankI
	{

	}
}
