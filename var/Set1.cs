using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	

	[Obsolete()]
	public class Set1
		:
		HashSet<nilnul.obj.VarI1>
		,_set_.BlankI

	{

		public Set1():base(nilnul.obj.var.Eq1.Instance)
		{

		}

		public Set1(IEnumerable<nilnul.obj.VarI1> vars):base(vars ) 
		{

		}


	}
}
