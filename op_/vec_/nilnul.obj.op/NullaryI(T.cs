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
	public  partial interface NullaryI<T>
		:OpI<T>
	{


		 T eval();



		


	}
}
