using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.str.be_._diff
{
	static public class _Extensions
	{
		static public bool BeDistinct(this IEnumerable<nilnul.obj.Var> vars) {
			if (vars.Count()==0)
			{
				return true;
			}
			else
			{
				var skipped = vars.Skip(1).ToArray();
				return BeDistinct(skipped) && skipped.NotContain(vars.First());
			}


		}
		static public bool BeDistinct(this IEnumerable<VarI1> vars) {
			if (vars.Count()==0)
			{
				return true;
			}
			else
			{
				var skipped = vars.Skip(1).ToArray();
				return BeDistinct(skipped) && skipped.NotContain(vars.First());
			}


		}
		static public void AssertDistinct(this IEnumerable<VarI1> vars) {

			nilnul.Assert1.True(BeDistinct(vars));

		}

		static public void AssertDistinct(this IEnumerable<Var> vars) {

			nilnul.Assert1.True(BeDistinct(vars));

		}
	}
}
