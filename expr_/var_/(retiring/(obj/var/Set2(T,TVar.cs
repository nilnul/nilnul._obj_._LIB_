using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	 

	public class Set2<T,TVar>
		:

		nilnul.obj.Set2<TVar>
		,
		nilnul.obj.var.SetI<T,TVar>

		where TVar:VarI6<T>
	{

		public Set2():base(nilnul.obj.var.Eq1<T,TVar>.Instance)
		{

		}

		public Set2(IEnumerable<TVar> vars):base(vars ) 
		{

		}

	
	}
}
