using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.call.op.nullary.call
{
	public partial class Literal<R>
		:
		CallI<R>
	{
		private R _val;

		public R val
		{
			get { return _val;}
			set { _val = value;}
		}
	


		public Literal( 			
			R val
		)
		{
			_val = val;

		}
		public R eval()
		{
			return _val;
			throw new NotImplementedException();
		}
	}
}
