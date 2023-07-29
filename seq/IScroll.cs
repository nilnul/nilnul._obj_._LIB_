using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq
{
	/// <summary>
	/// a window or telescope to watch a slice of the seq;
	/// for str, we can have some initials, and then keep that in memory and the next is the one after the history
	/// for stream, we can have something prefetched, and the next one is the first one of the prefetched, and we will replenish the prefetched.
	/// </summary>
	/// alias:
	///		window
	///		glimpse
	///		sleuth
	///		slip
	///		offset
	public interface IScroll
	{
	}
}
