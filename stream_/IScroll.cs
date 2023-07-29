using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_
{
	/// <summary>
	/// prefeched n terms;
	/// intitalliy n terms are known;
	/// but the index is before the 0th term and we need to movenext to get the 0th term. We then move n ahead,	and keep a history of n, where n=0,1,2,...;  we can still get any of the past n terms.
	///
	/// if n=0, this is <see cref="IStream"/>
	/// if n=1, this is a slider;
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// eg: we can move 1 ahead each time. or we can move 2 ahead each time. When moving, we can show all the skipped items or discard some, or we can even peek ahead some extra items.
	///
	/// vs:
	///		<seealso cref="slider_.IPreview"/> which books future, whileas this keep a history; we prefer <see cref="slider_.IPreview"/> which is consistent with <see cref="ISlider"/> and makes less misunderstanding;
	/// </remarks>
	/// alias:
	///		window
	///		preview
	///		frame
	///		offset
	///		lag
	///		lead
	///		buffered
	///		peek
	///
	[Obsolete(nameof(IPrefetch))]
	public interface IScroll:
		//IStream
		//,
		IPrefetch
	{
	}
}
