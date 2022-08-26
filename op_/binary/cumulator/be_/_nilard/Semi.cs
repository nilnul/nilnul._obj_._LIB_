using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_._nilard
{
	/// <summary>
	///  nilard on one side.
	///  
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		oneSided
	///		semi
	public interface ISemiNilard
	{
	}

	public interface SemiNilardI<T>:ISemiNilard
		,
		cumulator.Be_cumulatorGeneriI<T>
	{ }
}

/*Semi- is a prefix that means half, partially or almost. Semi- may also mean something that occurs twice within a specific amount of time. The prefix semi- is derived from the Latin semi- which means half. Most often, English words are constructed from words and word roots within the same foundation language. As semi- is a a Latin prefix, it is most often found with words that have Latin as their roots. Semi- is usually used to mean partially or half when talking about technical or scientific subjects, as well as math. When coining a word meaning half of something, English speakers will most often use the prefix semi-.

Hemi- is also a prefix that means half. The prefix hemi- is derived from the Greek hemi-, which means half. Hemi- is often employed when using language having to do with chemistry, math, biology and medicine.

Demi- is a prefix that means half, partially, or something that is slightly inferior. The prefix demi– is derived from the Old French word demi meaning half, derived from the Latin word dimidius. The prefix demi– is not seen nearly as often as the prefixes hemi– and semi-.*/
