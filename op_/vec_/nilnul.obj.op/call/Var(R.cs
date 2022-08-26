using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.call
{
	public partial class Var<R>
		:CallI<VarI<R>>
		
	{
		private VarI<R> _var;

		public VarI<R> var
		{
			get { return _var; }
			set { _var = value; }
		}
		

		public Var(nilnul.obj.VarI<R> var)
		{
			this._var = var;


		}

		public VarI<R> eval()
		{
			return _var;

			throw new NotImplementedException();
		}
	}
}
