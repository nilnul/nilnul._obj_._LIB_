using nilnul.obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.no
{


	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// 
	///morphism fro A to R
	public partial class Op<R>

		:
		OpI<R>
		
	{
		Func< R> _func;


		public Op(Func<R> op)
		{
			this._func = op;
		}

	
		public Op(R val)
		{
			this._func = ()=>val;
		}




		public R eval()
		{
			return _func();
			throw new NotImplementedException();
		}

	}
}
