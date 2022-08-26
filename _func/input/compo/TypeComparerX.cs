using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using CallI1 = nilnul.obj.func.input.compo.CallI;

namespace nilnul.obj.func.inputs.compo
{

	public partial class TypeComparerX
	{

		static public bool IsSubType(obj.func.input.compo.CallI x, CallI1 y)
		{
			if (x.boundVars.Count == y.boundVars.Count)
			{
				for (int i = 0; i < x.boundVars.Count; i++)
				{
					if (obj.var.TypeComparerX.IsNotSubType(x.boundVars.ElementAt(i), y.boundVars.ElementAt(i)))
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}
	}
}
