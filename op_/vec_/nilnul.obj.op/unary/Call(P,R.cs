using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary
{
	public partial class Call<P,R>
		:CallI<R>
	{
		private op.Unary<P,R> _op;

		public op.Unary<P,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		private P _para;

		public P para
		{
			get { return _para; }
			set { _para = value; }
		}
		public Call(Unary<P,R> op, P para)
		{
			this._op = op;
			this._para = para;

		}
		public Call(
			System.Func<P, R> func,P para	
		)
			:this(new Unary<P,R>(func),para)
		{

		}

		public R eval() {
			return _op.eval(_para);
		}
		
		
	}
}
