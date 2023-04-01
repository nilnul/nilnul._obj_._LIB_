using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom.term.extersed_.wung
{
	/// <summary>
	/// as <see cref="term.priored.IPremise"/> and <see cref="term.postiored.IRestriction"/>, we may regard, say, "_abc_", rather than <see cref="trivia.IExtension"/>, as an extension. But that would make later extensions to use <see cref="priored.IPostiored"/>, which is more lengthy/awkward to write.
	/// eg:
	///		for nilnul systerm, the first project is now named _nilnul_, and then many later projects begin with nilnul.
	///		If we were to exchange that two, then many later projects have to begin with _nilnul_
	/// </summary>
	///

	[Obsolete("would make later extensions more lengthy/awkward to write. ",true)]
	class IExtend
	{
	}
}
