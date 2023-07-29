using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.expr
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Literal< T>
		:obj.var.expr.LiteralI<T>
	{

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}
		
		public Literal(T val)
		{
			this._val = val;
		}
	}
}
