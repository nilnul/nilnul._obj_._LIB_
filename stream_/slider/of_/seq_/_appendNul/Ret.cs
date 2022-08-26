using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.slider.construct_.seq_._appendNul
{
	/// <summary>
	/// construct a stream from seq by appending null 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Ret<T>:
		IEnumerator<T>,
		nilnul.obj.SliderI<T>
		where T :class
	{
		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			//set { _enumerator = value; }
		}
		private T _current;
		public T current => _current;

		public T Current => _current;

		object IEnumerator.Current => _current;

		public Ret(IEnumerable<T> str)
		{
			_enumerator = str.GetEnumerator();
			moveNext();
		}

		

		public void moveNext()
		{
			_current= ( _enumerator.MoveNext() ? _enumerator.Current : null);
		}

		public void Dispose()
		{
			_enumerator.Dispose();
			//throw new NotImplementedException();
		}

		public bool MoveNext()
		{
			moveNext();
			return true;
			//throw new NotImplementedException();
		}

		public void Reset()
		{
			_enumerator.Reset();
			moveNext();
			//throw new NotImplementedException();
		}
	}
}
