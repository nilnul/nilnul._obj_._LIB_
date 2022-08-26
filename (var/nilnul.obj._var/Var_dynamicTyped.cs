using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._var
{
	public class Var_dynamicTyped : VarI_dynamicTyped
	{
		private Type _type;

		public Type type
		{
			get { return _type; }
			set { _type = value; }
		}

		public Var_dynamicTyped(Type type)
		{
			_type = type;

		}

		public override string ToString()
		{
			return $"{_type.ToString()} {nilnul.obj.var.NamingContext2.Name(this)}";
		}


	}
}
