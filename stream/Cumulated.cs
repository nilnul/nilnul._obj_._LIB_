using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream
{
	public class Cumulated<T, TStream, TOp,TFold>
		:
		nilnul.obj.Box<TStream>
		,
		nilnul.obj.stream_.SliderI<T>
		where TStream : nilnul.obj.StreamI2<T>
		where TFold: nilnul.obj.op_.binary.AccumulatorI<T,TOp>
		where TOp: nilnul.obj.op_.BinaryI<T>
	{
		private TFold _folder;

		public TFold folder	
		{
			get { return _folder; }
			set { _folder = value; }
		}

		private T _accumulated;

		public T current => _accumulated;

		public Cumulated(TStream val,TFold fold) : base(val)
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
	public class Cumulated<T, TStream,TFold>
		:
		nilnul.obj.Box<TStream>
		,
		nilnul.obj.stream_.SliderI<T>
		where TStream : nilnul.obj.StreamI2<T>
		where TFold: nilnul.obj.op_.binary.AccumulatorI<T>
	{
		private TFold _folder;

		public TFold folder	
		{
			get { return _folder; }
			set { _folder = value; }
		}

		private T _accumulated;

		public T current => _accumulated;

		public Cumulated(TStream val,TFold fold) : base(val)
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
	public class Cumulated_cumulatorDefault<T, TStream,TFold>
		:
		Cumulated<T, TStream,TFold>
		
		where TStream : nilnul.obj.StreamI2<T>
		where TFold: nilnul.obj.op_.binary.AccumulatorI<T>,new()
	{
		
		

		public Cumulated_cumulatorDefault(TStream val) : base(val, nilnul.obj_.Singleton<TFold>.Instance )
		{
		}
		

	}

}
