using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.var.set
{
	public class Eq : IEqualityComparer<IEnumerable<VarI1>>
	{
		public bool Equals(IEnumerable<VarI1> x, IEnumerable<VarI1> y)
		{

			return nilnul.obj.set.eq_._EqOfEnumerable.Eq(
				x,y, nilnul.obj.var.Eq1.Instance
			);
			//throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<VarI1> obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		static private Lazy<Eq> _Lazy = new Lazy<Eq>();
		static public Eq Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
