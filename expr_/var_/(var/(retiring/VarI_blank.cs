using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete(nameof(expr_.Var))]
	public abstract class VarA:VarI_blank1,nilnul.VarI1
	{
		public override string ToString()
		{
			return nilnul.var.set.NamingContext_ofVarI.Instance.getEnsuredName(this).val;

			return var.NamingContext3.StaticContext.name(this);
		}

	}
	[Obsolete(nameof(expr_.Var))]
	public interface VarI_blank1:nilnul.VarI1
	{



	}


}
