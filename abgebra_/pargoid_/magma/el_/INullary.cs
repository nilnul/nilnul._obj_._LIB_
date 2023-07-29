using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.pargoid_.magma.el_
{
	/// given x,
	///		for any y, x+y = y+x =y;
	///	then x is called neutral;
	/// <summary>
	/// if x is both <see cref="_neutral.IPriorNeutral"/> and <see cref="_neutral.IPosteriorNeutral"/>
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		nullary
	///		nullard
	///		nullare
	///		nullable
	///		nullifier
	///		nullify
	///		annillator
	///			,reserved for <see cref="cobiop_.magma4both.el_.nil_.IAnnihilator"/>
	///		void
	///		voider
	///		voder
	///		absorbent
	///		absorpent
	public interface INullary:_nullary.IPrior,_nullary.IPosterior
	{
	}
}
