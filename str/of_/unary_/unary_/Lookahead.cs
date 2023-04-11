using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.op_.unary_
{
	/// <summary>
	/// with the current char and also peek next char
	/// </summary>
	public class Lookahead<T> : nilnul.obj.Box1<IEnumerable<T>>
		,
		IEnumerator<T>
	{
		private IEnumerator<T>	_enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			set { _enumerator = value; }
		}

		public Lookahead(IEnumerable<T> val) : base(val)
		{
			_enumerator = val.GetEnumerator();

		}



		public T Current => _enumerator.Current;

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			_enumerator.Dispose();	
		}

		public bool MoveNext()
		{

			return _enumerator.MoveNext();
		}

		public void Reset()
		{
			_enumerator.Reset();

		}
	}
}
