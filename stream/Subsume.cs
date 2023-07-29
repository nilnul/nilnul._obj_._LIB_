using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream
{
	[Obsolete(nameof(stream_.slider.SubsumeI<T>) + " shall be used, as for this, when accumulating, we need to remeber the result, and the current is known;")]
	public class Subsume<T, TStream, TOp>
		:
		nilnul.obj.Box_ofIn<TStream>
		,
		SubsumeI<T>
		where TOp : nilnul.obj.of_.BinaryI<T>
		where TStream : nilnul.obj.StreamI2<T>
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

		public Subsume(TStream val, TOp op)
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
