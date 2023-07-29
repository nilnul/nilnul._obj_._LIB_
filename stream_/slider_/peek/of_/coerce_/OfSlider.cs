using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._stream_;

namespace nilnul.obj.stream_.slider_.peek.of_.coerce_
{
	static public class _OfSliderX
	{

		static public PeekI<T> ToPeek<T>(this nilnul.obj.stream_.SliderI<T> val)
		{

			return val is PeekI<T> v ? v : new _ofSlider.Ret<T>(val);

		}

		static public PeekI<T> ToPeek<T>(this nilnul.obj.StreamI2<T> val)
		{

			return ToPeek(
				obj.stream_.slider.of_.coerce_._OfStreamX.ToSlider(val)
			);

		}


	}
}
