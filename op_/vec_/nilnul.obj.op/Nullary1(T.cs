using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op
{
	/// <summary>
	/// Given T, there are #T of constant functions.
	/// </summary>
	public  class Nullary1<T>
		:OpI<T>,NullaryI<T>
	{
		private Func<T> _func;

		public Func<T> func
		{
			get { return _func; }
			set { _func = value; }
		}
		
	
		

		public Nullary1(Func<T>	_func)
		{
			this.func=func;	
		}

		public T eval() {

			return func();
		
		}



		


	}
}
