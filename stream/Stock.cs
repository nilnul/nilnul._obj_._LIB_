using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream
{
	/// <summary>
	/// for a stream, take the first n items, and n traverses from 0,1,2,3, ;note: here at first the first 0 items are taken;
	/// eg:
	///		for 0,1,2,3,...
	///		we get:
	///			[]
	///			[0]
	///			[0,1]
	///			[0,1,2]
	///	that is get a stream of str;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TStream"></typeparam>
	public class Stock<T, TStream>
		: nilnul.obj.stream_.SliderA<List<T>>
		,
		nilnul.obj.stream_._slider.CursorI<List<T>>
		,
		nilnul.obj.stream_.SliderI<List<T>>

		where TStream : nilnul.obj.StreamI2<T>


	{
		private  List<T> _initial = new List<T>();

		public List<T> initial
		{
			get { return _initial; }
			set { _initial = value; }
		}

		/// <summary>
		/// return the reference to the same list
		/// </summary>

		private TStream _stream;

		public TStream stream
		{
			get { return _stream; }
			set { _stream = value; }
		}

		public override List<T> current => _initial;

		public Stock(TStream val) 
		{
			_stream = stream;
		}

		public override void moveNext()
		{
			_initial.Add(_stream.next());
		}
	}
}
