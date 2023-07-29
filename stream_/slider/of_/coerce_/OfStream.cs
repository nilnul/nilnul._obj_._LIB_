using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._slider_;
using nilnul.obj._stream_;

namespace nilnul.obj.stream_.slider.of_.coerce_
{
	static public class _OfStreamX
	{
	

		static public SliderI<T> ToSlider<T>(this nilnul.obj.StreamI2<T> val) {

			return val is SliderI<T> v? v:  new _ofStream.Ret<T>(val);

		}
		

		
	}
}
