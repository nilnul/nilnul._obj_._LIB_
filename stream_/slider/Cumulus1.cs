using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider
{
	

	public class Cumulus1<T, TSlider, TFold, TOp>
	:
	nilnul.obj.Box_ofIn<TSlider>
	,
	CumulusI<T>
		,
		stream._cumulus_.CumulatorI<TFold>

	where TSlider : nilnul.obj.stream_.SliderI<T>
	where TFold : nilnul.obj.of_.binary.CumulatorI<T, TOp>
	where TOp : nilnul.obj.of_.BinaryI<T>
	{
		private TFold _folder;

		public TFold cumulator
		{
			get { return _folder; }
			set { _folder = value; }
		}

		private T _accumulated;

		public T current => _accumulated;

		public T toBeCumulated => boxed.current;

		public Cumulus1(TSlider val, TFold fold) : base(val)
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



	public class Cumulus1<T, TSlider,TCumulator>
		:
		nilnul.obj.Box_ofIn<TSlider>
		,
		nilnul.obj.stream_.slider.CumulusI<T>
		,
		stream._cumulus_.CumulatorI<TCumulator>

		where TSlider : nilnul.obj.stream_.SliderI<T>
		where TCumulator: nilnul.obj.of_.binary.CumulatorI<T>
	{
		private TCumulator _folder;

		public TCumulator cumulator	
		{
			get { return _folder; }
			set { _folder = value; }
		}

		private T _accumulated;
		public T current => _accumulated;

		public T toBeCumulated => boxed.current;

		public Cumulus1(TSlider val,TCumulator fold) : base(val)
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

	public class Cumulus1<T,TSlider>
		:
		Cumulus1<
			T, TSlider, nilnul.obj.of_.binary.CumulatorI<T>
		>
		where TSlider: stream_.SliderI<T>
	{
		public Cumulus1(TSlider val, nilnul.obj.of_.binary.CumulatorI<T> fold) : base(val, fold)
		{
		}

		public Cumulus1(
			TSlider val,
			nilnul.obj.of_.BinaryI<T> op,
			T ini
		)
			:
			this(
				val,
				new nilnul.obj.of_.binary.Cumulator<T>(ini,op)
			)
		{

		}
	}
	public class Cumulus1<T> : Cumulus1<T, nilnul.obj.stream_.SliderI<T>>
	{
		public Cumulus1(SliderI<T> val, nilnul.obj.of_.binary.CumulatorI<T> fold) : base(val, fold)
		{
		}

		public Cumulus1(
			SliderI<T> val,
			nilnul.obj.of_.BinaryI<T> op,
			T ini):this(
			val,
			new nilnul.obj.of_.binary.Cumulator<T>(ini,op)
		)
		{

		}
	}



}
