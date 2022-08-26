using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary
{
	public partial class Call1<P,R>
		:nilnul.obj.op.CallI<R>
	{
		private op.UnaryI<P,R> _op;

		public op.UnaryI<P,R> op
		{
			get { return _op; }
			set { _op = value; }
		}

		private nilnul.obj.op.CallI<P> _para;

		public nilnul.obj.op.CallI<P> para
		{
			get { return _para; }
			set { _para = value; }
		}
		public Call1(UnaryI<P,R> op, nilnul.obj.op.CallI<P> para)
		{
			this._op = op;
			this._para = para;

		}
		public Call1(
			System.Func<P, R> func,P para	
		)
			:this(new Unary<P,R>(func), new nilnul.obj.op.nullary.Call<P>( para))
		{

		}



		public R eval()
		{
			return op.eval(para.eval());
			throw new NotImplementedException();
		}
	}
}
