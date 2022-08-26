using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	/// <summary>
	/// a tag can simplely be another object,
	///		eg:
	///			abcd,
	///		or the object can be <see cref="tag_.IKeyVal"/>: "a:b"
	///	
	/// </summary>
	/// <remarks>
	/// type is prior info about data; tag is posterior info appended to an object.
	/// </remarks>
	public interface ITag
	{
	}
}
