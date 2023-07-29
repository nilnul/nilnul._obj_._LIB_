using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.sortie.op_.unary_
{
	/// <see cref="obj.set._CombinateX"/>
	/// <summary>
	/// get another sortie of the same elements. that is, the underlying set is the same;
	/// note to keep the sort unchanged is also a <see cref="sortie.op_.unary_.IRearrange"/>
	/// </summary>
	/// <remarks>
	/// all the resulted sorties form a set, called permutation or permutations;.
	/// the input can be set, instead of a sortie.
	/// </remarks>
	/// 
	/// alias:
	///		rearrange.
	///		reorder
	///		arrange
	///		reposition
	///		shuffle
	///			, if not specified, randomly.
	///		reshuffle
	///	vs:
	///		<see cref="sortie.IPermutation"/>, which is the set of all possible rearranges;
	///		<see cref="set.IPermutate"/>, which is not preferred, as this is more revealing in terms of clear definition.
	///		<see cref="set.op_.unary_.ISel"/>
	///		
	///		
	public interface IRearrange
	{
	}
}
