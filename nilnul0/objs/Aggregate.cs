using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	/// <summary>
	/// order will not affect the result. but the reating times of an el might affect the result.
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		this is in line with the definition in SQL
	/// </remarks>
	public interface IAggregate
	{
	}

	public interface IAggregate<T>
		:IAggregate
	{

	}


}
