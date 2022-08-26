using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	public class Eq<T> :

		nilnul.obj.Box1<IEqualityComparer<T>>
		,
		
		IEqualityComparer<nilnul.ObjsI3<T>>
		,
		IEqualityComparer<IEnumerable<T>>
		,
		EqI<T>
	{
		

		public Eq(IEqualityComparer<T> elementEq):base(elementEq)
		{

		}

		public Eq():this(EqualityComparer<T>.Default)
		{

		}
		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{
			return x.SequenceEqual(y,boxed);

		}
		public bool Equals(ObjsI3<T> x, ObjsI3<T> y)
		{

			return Equals(
				(IEnumerable<T>)x
				,
				(IEnumerable<T>)y

			);
			//throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<T> obj)
		{
			return 0;
		}

		public int GetHashCode(ObjsI3<T> obj)
		{
			return GetHashCode(
				(IEnumerable<T>)obj
			);
			//throw new NotImplementedException();
		}


		static public Eq<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq<T>>.Instance;
			}
		}

		static public Eq<byte> _OfBytes {
			get {
				return Eq<byte>.Singleton;
			}
		}
	}

}
