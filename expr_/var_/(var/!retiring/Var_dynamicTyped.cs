using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete(nameof(expr_.Var))]
	public class Var_dynamicTyped1 : VarI_dynamicTyped1
	{
		private Type _type;

		public Type type
		{
			get { return _type; }
			set { _type = value; }
		}

		public Var_dynamicTyped1(Type type)
		{
			_type = type;

		}

		//public override string ToString()
		//{
		//	return $"{_type.ToString()} {nilnul.obj.var.NamingContext2.Name(this)}";
		//}


	}
}
