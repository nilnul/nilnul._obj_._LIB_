using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.withType.s.duo.op
{
	public class Hook
	{
		static public SI Eval(SI x, SI y) {
			if (x.Any())
			{
				return new Headed(x.First(),
					
					Hook.Eval((x as Headed).tail,y)
					
				);
			}
			return y;
		}




	}
}
