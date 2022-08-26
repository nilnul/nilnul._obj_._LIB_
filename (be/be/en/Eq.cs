using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.en
{
	public class Eq<T >
		: nilnul.obj.avow.ed.Eq<T>
		,
		IEqualityComparer<EnI_beUnspecified<T>>


	{
		public Eq(IEqualityComparer<T> eq) : base(eq)
		{

		}

		public bool Equals(EnI_beUnspecified<T> x, EnI_beUnspecified<T> y)
		{
			return base.Equals(x, y);
		//	throw new NotImplementedException();
		}

		public int GetHashCode(EnI_beUnspecified<T> obj)
		{
			return base.GetHashCode(obj);

		//	throw new NotImplementedException();
		}
	}
}
