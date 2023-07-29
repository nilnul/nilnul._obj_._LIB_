using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._stream_;

namespace nilnul.obj.stream_.slider_.peek.of_.coerce_._ofSlider
{
	public class Ret<T>
		:

		nilnul.obj.stream_.slider_.PeekA<T>
		//,
		//PeekI<T>
	{
		private SliderI<T> _slider;

		public SliderI<T> slider
		{
			get { return _slider; }
			set { _slider = value; }
		}

		public override T ahead => _slider.current;

		T _current;
		public override T current => _current;

		public Ret(nilnul.obj.stream_.SliderI<T> val) 
		{
			_slider = val;
			moveNext();


		}
		//public Ret(nilnul.obj.stream_.slider.of_.coerce_._ofStream.Ret<T> val) :this( (nilnul.obj.stream_.SliderI<T>)val)
		//{
		//}

		public Ret(nilnul.obj.StreamI2<T> val) : this( nilnul.obj.stream_.slider.of_.coerce_._OfStreamX.ToSlider<T> (val))
		{

		}

		public override void moveNext()
		{
			_current = _slider.current;
			_slider.moveNext();

		}
	}
}
