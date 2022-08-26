using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	[Obsolete()]
	static public class SetX
	{
		static public string ToTxt(this HashSet<_var.VarI_dynamicTyped> varSet) {
			return "{"+string.Join(
                ";", 

				varSet.OrderBy(x => $"{x.type} {var.NamingContext2.Name(x)}")
				
			)+"}";
		}
	}

	 
}
