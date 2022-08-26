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
	public  class Nullary2<T>
		:NullaryI<T>
	{
		private T _func;

		public T func
		{
			get { return _func; }
			set { _func = value; }
		}
		
	
		

		public Nullary2(T	_func)
		{
			this.func=func;	
		}

		public T eval() {

			return func;
		
		}

		public class Call
			:nilnul.obj.op.Call_OpA<NullaryI<T>>
			,
			
			nilnul.obj.op.CallI<T>
		{
			public Call( NullaryI<T> op)
				:base(op)
			{

			}

			public Call(T val)
				:this(new Nullary2<T>(val))
			{

			}

			public T eval()
			{
				return op.eval();

				throw new NotImplementedException();
			}
		}



		


	}
}
