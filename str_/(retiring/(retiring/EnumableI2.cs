using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{

	[Obsolete()]
	public interface EnumableI2<T>:IEnumerable<T>,nilnul.obj.StrI1<T>
	{
	}

	[Obsolete()]

	public abstract class EnumableA2<T> :
		nilnul.obj.seq_._enumable_.GetEnumeratorA<T>
		,
		nilnul.obj.str_.EnumableI2<T>
	{

		private System.Collections.Generic.IEnumerable<T> _val;

		public System.Collections.Generic.IEnumerable<T> val
		{
			get { return _val; }
			set { _val = value; }
		}

		public EnumableA2(
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