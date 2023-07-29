using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._expr;
using nilnul.obj._var;

namespace nilnul.obj
{

	[Obsolete()]

	public abstract class ExprA<T>
		: ExprI_inheritDynamic<T>
	{
		public Type type
		{
			get
			{
				return typeof(T);

				throw new NotImplementedException();
			}
		}

		public abstract HashSet<VarI_dynamicTyped> vars
		{
			get
			;
		}

		public abstract ExprI_dynamic reduce();

		public abstract ExprI_dynamic substitute(VarI_dynamicTyped var, ExprI_dynamic expr)
		;
	}
}
