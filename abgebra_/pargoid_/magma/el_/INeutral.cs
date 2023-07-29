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
	///		neutron
	///			,like physics neutron, which doesnot add or decrease charge when being together with the atom or electrons;
	public interface INeutral:_neutral.IPriorNeutral,_neutral.IPosteriorNeutral
	{
	}
}
