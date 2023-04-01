using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom.term.co
{
	/// <see cref="_idiom.notion_.IJunc"/>
	/// <see cref="_idiom.concept_.IJunc"/>
	/// <summary>
	///  joiner between terms.
	///  eg:
	///		Abc4defXy0UvwKa
	///			where 0 is a ligture, as it's followed by a capital leter, whileas 4 is not, as it's followed by a lowercase letter so it's <see cref="_idiom.concept_.IJunc"/>
	///			ABC4DEF_XY_0_UVW_KA, when uppered. Note: around 0 we use same number of "_", but due to that its is a ligure, it still means the outermost grouping in:
	///				(ABC4DEF, XY ),0, (UVW, KA)
	///		ABC4DEF_XY_0_UVW_KA__Wy__0__XAA
	///			is grouped as:
	///				ABC4DEF_XY_0_UVW_KA__Wy, 0, XAA
	///					note around 0, the number of "_" is the same, but has higher grouping tier than the other "__"
	///			or further broke down:
	///				(ABC4DEF_XY_0_UVW_KA, Wy), 0, XAA
	///				
	///				
	///				
	/// </summary>
	/// alias:
	///		junction
	///		preposition
	///		ligature
	internal class ILigature
	{
	}
}
