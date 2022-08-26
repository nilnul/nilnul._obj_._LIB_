using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix
{
	public class Eq<T>
		: nilnul.obj.Box1<
			IEqualityComparer<T>
		>
		,
		IEqualityComparer<T[,]>
	{
		public Eq(IEqualityComparer<T> val) : base(val)
		{
		}

		public Eq() : this(EqualityComparer<T>.Default)
		{

		}
		public bool _eq_assumeSameSize(T[,] x, T[,] y)
		{

			for (int i = 0; i < x.GetLength(0); i++)
			{
				for (int j = 0; j < x.GetLength(1); j++)
				{
					if (!boxed.Equals(x[i, j], y[i, j]))
					{
						return false;
					}

				}

			}
			return true;
		}

		public bool Equals(T[,] x, T[,] y)
		{
			if (x.GetLength(0) == y.GetLength(0) && x.GetLength(1) == y.GetLength(1))
			{
				return _eq_assumeSameSize(x,y);
	
			}
			return false;

		}

		public int GetHashCode(T[,] obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


		static public Eq<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Eq<T>>.Instance;
			}
		}

	}
}
