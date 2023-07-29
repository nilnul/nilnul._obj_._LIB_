using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.var.set
{
	public class EqOfEnumerable<T> : IEqualityComparer<IEnumerable<VarI5<T>>>
	{
		public bool Equals(IEnumerable<VarI5<T>> x, IEnumerable<VarI5<T>> y)
		{

			return nilnul.obj.set.eq_._EqOfEnumerable.Eq(
				x,y, nilnul.obj.var.Eq1.Instance
			);
			//throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<VarI5<T>> obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		static private Lazy<EqOfEnumerable<T>> _Lazy = new Lazy<EqOfEnumerable<T>>();
		static public EqOfEnumerable<T> Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
