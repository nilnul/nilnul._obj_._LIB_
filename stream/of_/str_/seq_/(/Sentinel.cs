using System.Collections.Generic;

namespace nilnul.obj.stream_.seq_
{
	/// <summary>
	/// sentinel
	/// </summary>
	public class Sentinel<T> : 
		nilnul.obj.Box<IEnumerable<T>>
		,
		nilnul.obj.StreamI<T>
	{
		

		private T _sentinel;

		public T sentinel
			{
				get => _sentinel;
				set => _sentinel = value;
			}

		public Sentinel(IEnumerable<T> seq, T sentinel):base(seq)
		{
			boxed = seq;
			_sentinel = sentinel;
			_enumerator = boxed.GetEnumerator();
		}

		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
			{
				get => _enumerator;
				set => _enumerator = value;
			}


		public T next()
		{

			if (_enumerator.MoveNext())
			{
				return _enumerator.Current;
			}
			else
			{
				return _sentinel;
			}



		}
	}
}


