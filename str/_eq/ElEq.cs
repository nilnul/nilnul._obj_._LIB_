using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs._eq
{

	public class _ElEq<T,TEq>
		where TEq:IEqualityComparer<T>
	{
		private TEq _elEq;

		public TEq elEq
		{
			get { return _elEq; }
			set { _elEq = value; }
		}

		public _ElEq(TEq elEq)
		{
			_elEq = elEq;
		}

	}

	public class ElEq<T> : _ElEq<T, IEqualityComparer<T>>
	{
		public ElEq(IEqualityComparer<T> elEq) : base(elEq)
		{
		}
	}

	public class ElEq<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{


		public TEq elEq
		{
			get { return nilnul.obj.SingletonByDefault<TEq>.Instance; }
			//set { _elEq = value; }
		}


		static public ElEq<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<ElEq<T,TEq>>.Instance;
			}
		}




	}
}
