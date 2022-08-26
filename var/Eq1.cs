using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var
{
	/// <summary>
	/// this is the default one: Reference Eq. So this is necessary.
	/// </summary>
	[Obsolete(nameof(expr_.var.Eq))]

	public class Eq1 : IEqualityComparer<VarI1>
		,
		IEqualityComparer<IVar>
	{
		static public readonly Eq1 Instance = new Eq1();

		public bool Equals(VarI1 x, VarI1 y)
		{
			return object.ReferenceEquals(x, y);

			//throw new NotImplementedException();
		}

		public bool Equals(IVar x, IVar y)
		{
			if (x is var_._handled_.HandleI xH)
			{
				if (y is var_._handled_.HandleI yH )
				{
					return xH.handle == yH.handle;
				}

			}
			return x == y;
			throw new NotImplementedException();
		}

		public int GetHashCode(VarI1 obj)
		{
			return obj.GetHashCode();
			//throw new NotImplementedException();
		}

		public int GetHashCode(IVar obj)
		{
			if (obj is var_._handled_.HandleI xH)
			{
				return xH.GetHashCode();

			}
			return obj.GetHashCode();

			//throw new NotImplementedException();
		}
	}


}
