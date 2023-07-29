using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var
{
	[Obsolete(nameof(expr_.var.Eq))]
	public class Eq : IEqualityComparer<VarI_blank1>
	{
		public bool Equals(VarI_blank1 x, VarI_blank1 y)
		{
			return x == y;
			throw new NotImplementedException();
		}

		public int GetHashCode(VarI_blank1 obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
