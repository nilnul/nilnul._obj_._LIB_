using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tups._tbl
{
	/// <summary>
	/// the columns;
	/// </summary>
	/// <remarks>
	///in fact header is a str, as each col definition is of the same type; so it's not a tup. so col is not a cel;
	/// it's not a <see cref="obj.IVec"/>, as the count of cols are arbitrary, and the cels count of each tup is dependent on this;
	/// </remarks>
	/// alias:
	///		schema
	///		struc
	public interface IHeader
		:row_.INonTup
		,
		obj.IStr //  in fact header is a str, as each col definition is of the same type; so it's not a tup. so col is not a cel;
	{
	}


}
