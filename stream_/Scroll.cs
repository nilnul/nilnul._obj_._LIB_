using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_
{
	/// <summary>
	/// move p ahead, where p is positive.
	/// eg: we can move 1 ahead each time. or we can move 2 ahead each time. When moving, we can show all the skipped items or discard some, or we can even peek ahead some extra items.
	/// </summary>
	/// <remarks>
	/// alias:
	///		window
	///		preview
	///		frame
	///		offset
	///		lag
	///		lead
	///		buffered
	///		peek
	/// </remarks>
	public interface IScroll:
		IStream
	{
	}
}
