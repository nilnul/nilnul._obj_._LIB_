using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op.nullary.call
{

		public class Ref<R>
			:ExprI<R>
		{
			private nilnul.obj.ValI<R> _val;

			public nilnul.obj.ValI<R> val
			{
				get { return _val; }
				set { _val = value; }
			}

			public Ref(nilnul.obj.ValI<R> val)
			{
				_val = val;

			}
			public ExprI<R> substitute<V>(VarI<V> var, ExprI<V> expr)
			{
				return this;
				throw new NotImplementedException();
			}

			public ExprI<R> demote()
			{
				if (_val is nilnul.obj.val.LiteralI)
				{
					return new obj.expr.Call<R>( 
						new nilnul.obj.call.op.nullary.call.Literal<R>(
							(_val as nilnul.obj.val.LiteralI<R>	).val
						)
					);
					
				}
				return this;

				throw new NotImplementedException();
			}
		}
	
}
