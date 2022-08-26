using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._alt.val_
{
	public class Typed<T,T1>:ValI<T,T1>
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Typed(

			T val
		)
		{
			_val = val;
		}

	}
}
