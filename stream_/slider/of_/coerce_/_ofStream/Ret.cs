using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._slider_;
using nilnul.obj._stream_;

namespace nilnul.obj.stream_.slider.of_.coerce_._ofStream
{
	/// <summary>
	/// not every coerce needs this as some stream is already slider;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Ret<T>
		:
		_slider.skim_.OfStream<T>
		,
		nilnul.obj.stream_.SliderI<T>
	{
		public Ret(nilnul.obj.StreamI2<T> val) : base(val)
		{

		}

	
		

		public T next()
		{
			return _slider.SkimX.Next(this);

		}
	}
}
