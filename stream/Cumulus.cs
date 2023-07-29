using nilnul.obj.stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream
{
	public class Cumulus<T, TStream, TOp, TFold>
		:
		nilnul.obj.Box_ofIn<TStream>
		,
		nilnul.obj.stream_.SliderI<T>
		,
		CumulusI<T>
		,
		_cumulus_.CumulatorI<TFold>

		where TStream : nilnul.obj.StreamI2<T>
		where TFold : nilnul.obj.of_.binary.CumulatorI<T, TOp>
		where TOp : nilnul.obj.of_.BinaryI<T>
	{
		private TFold _cumulator;

		public TFold cumulator
		{
			get { return _cumulator; }
			set { _cumulator = value; }
		}

		private T _current;

		public T current => _current;

		public Cumulus(TStream val, TFold fold) : base(val)
		{
			_cumulator = fold;
			_current = fold.initial;
		}
		public void moveNext()
		{
			_current = _cumulator.binder.op(_current, boxed.next());
		}

		public T next()
		{
			return nilnul.obj.stream_._slider.CursorX.Next(this);
		}

	}


	public class Cumulus<T, TStream, TFold>
		:
		Cumulus<T, TStream, obj.of_.BinaryI<T>, TFold>
		,
		nilnul.obj.StreamI2<T>
		where TStream : nilnul.obj.StreamI2<T>
		where TFold : nilnul.obj.of_.binary.CumulatorI<T>
	{

		public Cumulus(TStream val, TFold fold) : base(val, fold)
		{



		}

	}
	public class Cumulus<T, TStream>
		:
		Cumulus<T, TStream, nilnul.obj.of_.binary.CumulatorI<T>>
		,
		nilnul.obj.StreamI2<T>
		where TStream : nilnul.obj.StreamI2<T>
	{

		public Cumulus(TStream val, nilnul.obj.of_.binary.CumulatorI<T> fold) : base(val, fold)
		{



		}

	}

	public class Cumulus<T >
		:
		Cumulus<T, nilnul.obj.StreamI2<T>>
		,
		nilnul.obj.StreamI2<T>
	{

		public Cumulus(nilnul.obj.StreamI2<T> val, nilnul.obj.of_.binary.CumulatorI<T> fold) : base(val, fold)
		{



		}

	}



	

}
