using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.withType
{
	public partial class Var: VarI
	{
		public Var(Type type)
		{
			this.type = type;

		}
		public Type type
		{
			get;
			set;
			
		}

		


	}
}
