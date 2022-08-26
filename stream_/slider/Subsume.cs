using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider
{
	public class Subsume<T, TSlider, TOp>
		:
		nilnul.obj.Box<TSlider>
		,
		nilnul.obj.stream_.SliderI<T>

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
	public class Subsume_sliderGeneral<T,  TOp>
		:
		Subsume<T,nilnul.obj.stream_.SliderI<T>, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		public Subsume_sliderGeneral(nilnul.obj.stream_.SliderI<T>  val, TOp op)
			:
			base(val, op)
		{
		}
	}


	public class Subsume_opDefault<T, TSlider, TOp>
		: Subsume<T, TSlider, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
		where TSlider : nilnul.obj.stream_.SliderI<T>
	{
		public Subsume_opDefault(TSlider val)
			:
			base(val, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}


	public class Subsume_opDefault_sliderNew<T, TSlider, TOp>
		: Subsume_opDefault<T, TSlider, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
		where TSlider : nilnul.obj.stream_.SliderI<T>,new()
	{
		public Subsume_opDefault_sliderNew()
			:
			base(new TSlider())
		{
		}
	}

	public class Subsume_opDefault_sliderGeneral<T,  TOp>
		: Subsume<T,nilnul.obj.stream_.SliderI<T>, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public Subsume_opDefault_sliderGeneral(nilnul.obj.stream_.SliderI<T> val)
			:
			base(val, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}

}
