using nilnul.obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.no
{

	public class Constant<T> : OpI<T>
	{

		private T _val;

		public T val {
			get { return _val; }
		}
		public Constant(T val)
		{
			_val = val;
		}
		public T eval()
		{
			return _val;


			throw new NotImplementedException();
		}


		static public implicit operator T(Constant<T> op) {
			return op.val;
		}

		static public implicit operator Constant<T> (T val) {
			return new Constant<T>(val);
		}


	}

	
}
