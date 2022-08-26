using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	[Obsolete()]
	public class Eq<T> :

		nilnul.obj.Box<IEqualityComparer<T>>
		,
		
		IEqualityComparer<nilnul.ObjsI2<T>>
	{
		

		public Eq(IEqualityComparer<T> elementEq):base(elementEq)
		{

		}
		public bool Equals(ObjsI2<T> x, ObjsI2<T> y)
		{
			return x.toArr().SequenceEqual(y.toArr(), this.boxed);
			//throw new NotImplementedException();
		}

		public int GetHashCode(ObjsI2<T> obj)
		{
			return 0;
			//throw new NotImplementedException();
		}

	}

	[Obsolete()]
	public class Eq<T,TEq> :Eq<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Eq():base( nilnul.obj.SingletonByDefault<TEq>.Instance)
		{

		}

		static public Eq<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Eq<T,TEq>>.Instance;
			}
		}

	}
}
