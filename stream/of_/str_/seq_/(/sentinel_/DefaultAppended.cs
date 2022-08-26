using System.Collections.Generic;

namespace nilnul.obj.stream_.seq_
{
	/// <summary>
	/// sentinel
	/// </summary>


	public class DefaultAppended<T>
			:

			nilnul.obj.StreamI<T>
		,
		nilnul.obj.StreamI2<T>
			where T : class
	{
		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator => _enumerator;


		public DefaultAppended(IEnumerable<T> str)
		{
			_enumerator = str.GetEnumerator();
		}

		public T next()
		{
			return _enumerator.MoveNext() ? _enumerator.Current : default(T);

			//throw new NotImplementedException();
		}


	}


}

