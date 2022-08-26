using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_._slider_
{
	[Obsolete(nameof(nilnul.obj.stream_._slider.CursorX))]
	static public class NextX
	{
		static public T Next<T>(this nilnul.obj.stream_.SliderI<T> slider) {
			var old = slider. current;
			slider.moveNext();
			return old;
		}
	}
}
