using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom.term._adfixed.adfix_
{
	/// <summary>
	/// </summary>
	enum _SuffixE
	{
		/// <summary>
		/// abstract class
		/// </summary>
		A
			,
		/// <summary>
		/// enum.
		///		eg:
		///			AbcE
		/// often used for <see cref="circa_.Prefixed"/>
		/// eg:
		///		_AbcE
		/// </summary>
		/// <remarks>
		/// alias:
		///		N
		/// </remarks>
		/// 
		E
			,
		/// <summary>
		/// struct
		/// </summary>
		/// <remarks>
		/// alias:
		///		V
		/// </remarks>
		S
			,
		/// <summary>
		/// <see cref="adfix_.IForInterface"/>
		/// </summary>
		I
			,
		/// <summary>
		/// a windows control
		/// </summary>
		C
			,
		/// <summary>
		/// a web control
		/// </summary>
		W
			,
		/// <summary>
		/// extension methods.
		/// can apply to <see cref="ITerm"/>, meaning extension of it.
		/// or can apply to <see cref="term.circa_.pre"/>, meaning extension methods prior to the definitin of a type.
		/// </summary>
		/// <remarks>
		/// extension methods shall be defined right after the <see cref="_obj._typ._ns.ISeg"/> synonym to the type.
		/// In fact any other types shall be defined right after the seg for the type.
		/// </remarks>
		X
	}
}

