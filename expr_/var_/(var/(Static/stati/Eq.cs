using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.stati
{
	public class Eq : IEqualityComparer<StatiI>
	{

		static public Eq Singleton = SingletonByDefault<Eq>.Instance;
		public bool Equals(StatiI x, StatiI y)
		{
			return x == y;

			throw new NotImplementedException();
		}

		public int GetHashCode(StatiI obj)
		{
			return obj.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
