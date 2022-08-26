using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._alt.val_
{
	public class Typed1<T,T1>:ValI<T,T1>
	{
		private T1 _val;

		public T1 val
		{
			get { return _val; }
			set { _val = value; }
		}

		public Typed1(

			T1 val
		)
		{
			_val = val;
		}

	}
}
