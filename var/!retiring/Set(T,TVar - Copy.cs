using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	 
	[Obsolete()]
	public class Set<T,TVar>
		:
		HashSet<TVar>
		,
		nilnul.obj._set_.ContainsI<TVar>

		where TVar:VarI5<T>
	{

		public Set():base(nilnul.obj.var.Eq<T,TVar>.Instance)
		{

		}

		public Set(IEnumerable<TVar> vars):base(vars ) 
		{

		}

		public bool contains(TVar element)
		{
			return Contains(element);
			throw new NotImplementedException();
		}
	}
}
