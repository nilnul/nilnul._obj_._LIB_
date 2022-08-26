using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.nullary
{
	public partial class Call<T>
		:CallI<T>
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}
		
		public Call(T val)
		{
			this._val = val;

		}
		public T eval()
		{
			return _val;
			throw new NotImplementedException();
		}
	}
}
