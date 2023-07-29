using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a text uniquely identifies an object, which can be a num, in this case, the Id can be a "123", or other decimal number.
	/// </summary>
	/// <remarks>
	/// obj can be very complex. for example, a program, a snippet of code, or an expression. In this case the name/nom/id is not a good way to express it. So we defer the definition of Name to specific objects defined in a particular domain.
	/// </remarks>
	/// an obj might be constituted in different forms.
	/// eg:
	///		Seq with an Eq can be regarded as set. But the seq might be reordered, deduplicated when the set is converted back to a seq.
	///
	/// 
	/// alias:
	///		id
	///		phrase
	///	<see cref="IWord"/>
	///	<seealso cref="IId"/>
	///
	public interface ILex
	{
	}

	
}
