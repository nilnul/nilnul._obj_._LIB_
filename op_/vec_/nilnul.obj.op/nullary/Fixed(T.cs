using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op.nullary
{
	/// <summary>
	/// Given T, there are #T of constant functions.
	/// </summary>
	public  class Fixed<T>
		:
		nilnul.obj.op.FixedA<T>
		,
		nilnul.obj.op.NullaryI<T>
		
		
	{
	
		
		

		public Fixed(	T arg)
			:base(arg)
		{
			
		}

		public T eval() {

			return val;
		
		}



		


	}
}
