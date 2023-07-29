using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_.pargoid_.magma.el.be_
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
	public interface INeutral:_neutral.IPriorNeutral,_neutral.IPosteriorNeutral
	{
	}
}
