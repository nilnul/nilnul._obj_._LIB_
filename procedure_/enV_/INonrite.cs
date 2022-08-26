using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.procedure_.enV_
{
	/// <summary>
	/// doesnot change the environment, but it's possible in addition to reading inputs, also reading the environment.
	/// cuz environment might be changed by others, hence the output of the procedure is not definite.
	/// 
	/// making the read variable readonly would make sure the procedure unable to change it. Or using the c# "in" parameter.
	/// Or we use immutable data.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		nonrite
	/// <!---->
	/// <!---->
	interface INonrite
	{
	}
}
