using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be_
{
	public class FroFunc<T>
		: BeI<T>
		

	{
		private System.Func<T, bool> _func;

		public Func<T,bool> func
		{
			get { return _func; }
			set { _func = value; }
		}



		public FroFunc(System.Func<T, bool> func)
		{
			_func = func;
		}
		public bool be(T obj)
		{
			return _func(obj);
			//throw new NotImplementedException();
		}

	}

}
