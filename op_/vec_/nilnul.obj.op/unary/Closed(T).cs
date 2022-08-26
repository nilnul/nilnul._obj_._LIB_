using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op.unary
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// 
	///morphism fro A to R
	public partial class Closed<T>
		:nilnul.obj.op.unary.Op<T,T>
		
	{
		

		public Closed(System.Func<T, T> op)
			:base(op)
		{
			
		}


	
	}
}
