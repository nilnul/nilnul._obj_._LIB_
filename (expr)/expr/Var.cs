using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
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
		private nilnul.obj.VarI1 _var;

		public nilnul.obj.VarI1 var
		{
			get { return _var; }
			set { _var = value; }
		}
		

		public Var( nilnul.obj.VarI1 var  )
		{
			_var = var;

		}

		public Var()
			:this(new nilnul.obj.Var())
		{

		}

		public override string ToString()
		{
			return _var.ToString();
		}

	}
}
