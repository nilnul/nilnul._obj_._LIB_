using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_._slider
{
	static public class SkimX
	{
		static public T Next<T>(this SkimI<T> slider) {
			var old = slider. current;
			slider.moveNext();
			return old;
		}
	}
	static public class SkidX
	{
		static public T Next<T>(this SkidI<T> slider) {
			var old = slider. current;
			slider.moveNext();
			return old;
		}
	}


}
