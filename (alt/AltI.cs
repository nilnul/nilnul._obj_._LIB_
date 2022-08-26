using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface AltI
	{

	}


	public interface AltI<T, T1>:AltI {

	}

	public class Alt<T,T1>
		:AltI<T,T1>
	{

		private _alt.ValI<T,T1> _val;

		public _alt.ValI<T,T1> val
		{
			get { return _val; }
			set { _val = value; }
		}


		public Alt(T val)
		{
			_val = new _alt.val_.Typed<T,T1>(val);
		}

		public Alt(T1 val)
		{
			_val = new _alt.val_.Typed1<T, T1>(val);
		}



	}
}
