using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream.construct_._seq
{
	/// <summary>
	/// construct a stream from seq by appending null 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete()]
	public class Ret<T>:nilnul.obj.StreamI<T>
		where T :class
	{
		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			//set { _enumerator = value; }
		}


		public Ret(IEnumerable<T> str)
		{
			_enumerator = str.GetEnumerator();
		}

		public T next()
		{
			return _enumerator.MoveNext() ? _enumerator.Current : null;

			//throw new NotImplementedException();
		}
	}
}
