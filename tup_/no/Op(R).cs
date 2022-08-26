using nilnul.obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.no
{

	public class Constant<T> : OpI<T>
	{

		private T _val;

		public T val {
			get { return _val; }
		}
		public Constant(T val)
		{
			_val = val;
		}
		public T eval()
		{
			return _val;


			throw new NotImplementedException();
		}


		static public implicit operator T(Constant<T> op) {
			return op.val;
		}

		static public implicit operator Constant<T> (T val) {
			return new Constant<T>(val);
		}


	}

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
