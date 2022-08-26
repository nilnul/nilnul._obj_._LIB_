using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set
{
	/// <summary>
	/// order will not affect the result. repeating of same element will not affect the result. <seealso cref="nameof(objs.IAggregate)"/>
	///
	/// For a sequence of objs, if we apply this, the repeating elements are removed, leaving only one occurence. If we apply <see cref="nameof(objs.IAggregate)"/>, the repeating elements are not removed. So we better name the two terms differently.
	/// </summary>
	/// <remarks>
	///		nomenclature
	///			:
	///			similar to aggregate, but not the same
	/// </remarks>
	public interface IAgglomerate

	{
	}
}
