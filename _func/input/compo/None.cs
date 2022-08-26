using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.input.compo
{
	public class None
		:CallI
	{
		public HashSet<VarI1> boundVars
		{
			get {

				return new HashSet<VarI1>();
				throw new NotImplementedException();
			}
		}
	}
}
