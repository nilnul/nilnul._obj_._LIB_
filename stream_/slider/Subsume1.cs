using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider
{
	public class Subsume1<T, TSlider, TOp>
		:
		nilnul.obj.Box_ofIn<TSlider>
		//,
		//nilnul.obj.stream_.SliderI<T>
		,
		SubsumeI<T>
		,
		_subsume_.CombinerI<TOp>

		where TOp : nilnul.obj.of_.BinaryI<T>
		where TSlider : nilnul.obj.stream_.SliderI<T>
	{
		private TOp _combiner;

		public TOp combiner
		{
			get { return _combiner; }
			set { _combiner = value; }
		}
		private T _current;
		public T current => _current;

		public T justCumulated => boxed.current;

		public Subsume1(TSlider val, TOp op)
			:
			base(val)
		{
			_combiner = op;
			_current = boxed.current;
		}

		public void moveNext()
		{
			boxed.moveNext();
			_current = _combiner.op(_current, boxed.current);
		}
		public T next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}

	}

	public class Subsume<T, TSlider>
	:
	Subsume1<T, TSlider,nilnul.obj.of_.BinaryI<T>>
	where TSlider : nilnul.obj.stream_.SliderI<T>
	{
		public Subsume(TSlider val, nilnul.obj.of_.BinaryI<T> op)
			:
			base(val, op)
		{
		}
	}

	public class Subsume<T>
	:
	Subsume<T, nilnul.obj.stream_.SliderI<T>>
	{
		public Subsume(nilnul.obj.stream_.SliderI<T> val, nilnul.obj.of_.BinaryI<T> op)
			:
			base(val, op)
		{
		}
	}



}
