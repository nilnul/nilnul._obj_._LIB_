using nilnul.obj.op._ed_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op
{
	 
	[Obsolete()]
	public class Ed<T>
		: _ed_.EdI<T>
	{

		public Ed( T val, nilnul.obj.OpI<T> op)
		{
			_processed = op.eval(val);
		}
		private T _processed;
		public T processed
		{
			get
			{
				return _processed;
			//	throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			return _processed.ToString();
		}

		static public  implicit operator T(Ed<T> ed) {
			return ed.processed;
		}
	}
}
