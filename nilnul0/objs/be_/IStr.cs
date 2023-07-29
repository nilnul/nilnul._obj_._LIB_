using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_
{
	/// <summary>
	/// if it has a scope; we 'll keep the order constant, whileas <see cref="IObjs"/>'s order is subject to change without notice;
	/// eg:
	///		[] is str, which encloses "" without quoation mark;
	///		[a,b] is str, whileas a,b is <see cref="IObjs"/>
	///		
	/// </summary>
	internal class IStr
	{
	}
}
