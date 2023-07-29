using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.withType.expr
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Var
		:
		//nilnul.obj.Var
		//,

		VarI
	{
		private var.withType.VarI _var;

		public var.withType.VarI var
		{
			get { return _var; }
			set { _var = value; }
		}

		public Type type
		{
			get
			{
				return _var.type;
				throw new NotImplementedException();
			}
		}

		public Var( var.withType.VarI var  )
		{
			_var = var;

		}

		public Var(Type type)
			:this(new withType.Var(type))
		{

		}

		public ExprI demote()
		{
			return this;
			throw new NotImplementedException();
		}

		public ExprI substitute(withType.VarI var, ExprI expr)
		{
			//

			throw new NotImplementedException();
		}
	}
}
