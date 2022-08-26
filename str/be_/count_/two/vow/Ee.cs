using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.count_.two.vow
{

	public class Ee<T>
		:
		nilnul.obj.str.vow.ee_.VowNeo<T,Vow<T>>

	{
		public Ee(
			IEnumerable<T> val
		)
			:
			base( val)
		{
		}


		public Ee(
			params T[] elements
		)
		:this(
			(IEnumerable<T>)(elements) 
		)
		{
		}

	}
}