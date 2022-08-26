using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec
{
	/// <summary>
	/// unlike str.Eq, here we assume the two vec are of the same arity
	/// </summary>

	public class Eq<T> :
		nilnul.obj.Box1<IEqualityComparer<T>>,

		IEqualityComparer<IEnumerable<T>>
	{
		public Eq(IEqualityComparer<T> val) : base(val)
		{
		}
		public Eq():this( EqualityComparer<T>.Default)
		{

		}

		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{
			return x.SequenceEqual(y, boxed);
			//throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<T> obj)
		{
			return 0;
			//throw new NotImplementedException();
		}
	}
}
