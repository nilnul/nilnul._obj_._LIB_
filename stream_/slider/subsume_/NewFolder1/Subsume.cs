using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider
{
	[Obsolete(nameof(slider.ISubsume))]
	public class Subsume<T, TSlider, TOp>
		:
		nilnul.obj.Box<TSlider>
		,
		nilnul.obj.stream_.SliderI<T>
		, SubsumeI<T>
		where TOp : nilnul.obj.op_.BinaryI<T>
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

		public Subsume(TSlider val, TOp op)
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

}
