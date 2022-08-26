using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_._slider
{
	static public class CursorX
	{
		static public T Next<T>(this nilnul.obj.stream_._slider.CursorI<T> slider) {
			var old = slider. current;
			slider.moveNext();
			return old;
		}
	}
}
