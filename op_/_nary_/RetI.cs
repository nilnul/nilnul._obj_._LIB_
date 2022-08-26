using nilnul._obj._op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._nary_
{
	public interface RetI<out TRet>:
		nilnul.obj._op_.RetI<TRet> 
		,
		BlankI
	{
		TRet op();
	}

	public class Ret<T> : RetI<T>
	{
		private T _ret;
		public Ret(T ret)
		{
			_ret = ret;
		}
		public T op()
		{
			return _ret;
			//throw new NotImplementedException();
		}
		public T val { get { return _ret; } }

		public override string ToString()
		{
			return _ret.ToString();
		}
	}
}
