using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.procedure_.enV_
{
	/// <summary>
	/// reading nothing from the environment except inputs. So the outputs are soley determined by the inputs. In this way, this is a pure procedure, or in other words, funciton.
	/// But this procedure also write to the environment, possiblly changing the enviroment.
	///
	/// Or using the c# "out" parameter.
	/// </summary>
	/// <remarks>
	/// eg:
	///		trace.Write inside a procedure would make the procedure <see cref="INonread"/>
	/// </remarks>
	/// alias:
	///		nonread
	///		
	interface INonread
	{
	}
}
