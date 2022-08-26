using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	
	public interface SeqI<T>:IEnumerable<T>,nilnul.obj.StrI1<T>
	{
	}


	public abstract class SeqA<T> :
		nilnul.obj.seq_.GetEnumeratorA<T>
		,
		nilnul.obj.str_.SeqI<T>
	{

		private System.Collections.Generic.IEnumerable<T> _val;

		public System.Collections.Generic.IEnumerable<T> val
		{
			get { return _val; }
			set { _val = value; }
		}

		public SeqA(
			System.Collections.Generic.IEnumerable<T> val
		)
		{
			_val = val;
		}

		public T[] toArr()
		{
			return _val.ToArray();
		}

	}
}