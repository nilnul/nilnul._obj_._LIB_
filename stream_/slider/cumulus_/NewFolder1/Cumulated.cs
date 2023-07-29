using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider
{
	[Obsolete(nameof(Cumulus1<T>))]

	public class Cumulus<T, TSlider, TOp, TFold>
	:
	nilnul.obj.Box<TSlider>
	,
	nilnul.obj.stream_.SliderI<T>
		,
		_cumulus_.NextCumulee<T>

	where TSlider : nilnul.obj.stream_.SliderI<T>
	where TFold : nilnul.obj.op_.binary.AccumulatorI<T, TOp>
	where TOp : nilnul.obj.op_.BinaryI<T>
	{
		private TFold _folder;

		public TFold folder
		{
			get { return _folder; }
			set { _folder = value; }
		}

		private T _accumulated;

		public T current => _accumulated;

		public T toBeCumulated => boxed.current;

		public Cumulus(TSlider val, TFold fold) : base(val)
		{
			_folder = fold;
			_accumulated = fold.initial;
		}
		public void moveNext()
		{
			_accumulated = _folder.binder.op(_accumulated, boxed.next());
		}

		public T next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}

	}


	[Obsolete(nameof(Cumulus1<T>))]

	public class Cumulus<T, TSlider,TCumulator>
		:
		nilnul.obj.Box<TSlider>
		,
		nilnul.obj.stream_.SliderI<T>
		,
		_cumulus_.NextCumulee<T>
		where TSlider : nilnul.obj.stream_.SliderI<T>
		where TCumulator: nilnul.obj.op_.binary.AccumulatorI<T>
	{
		private TCumulator _folder;

		public TCumulator folder	
		{
			get { return _folder; }
			set { _folder = value; }
		}

		private T _accumulated;
		public T current => _accumulated;

		public T toBeCumulated => boxed.current;

		public Cumulus(TSlider val,TCumulator fold) : base(val)
		{
			_folder = fold;
			_accumulated = fold.initial;
		}
		public void moveNext()
		{
			_accumulated= _folder.binder.op(_accumulated,boxed.next());
		}

		public T next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}

	}

	[Obsolete(nameof(Cumulus1<T>))]
	public class Cumulus<T> : Cumulus<T, nilnul.obj.stream_.SliderI<T>, nilnul.obj.op_.binary.AccumulatorI<T>>
	{
		public Cumulus(SliderI<T> val, AccumulatorI<T> fold) : base(val, fold)
		{
		}

		public Cumulus(SliderI<T> val,
			nilnul.obj.op_.BinaryI<T> op,
			T ini):this(
			val,
			new nilnul.obj.op_.binary.Accumulator_opGeneric<T>(ini,op)
		)
		{

		}
	}

}
