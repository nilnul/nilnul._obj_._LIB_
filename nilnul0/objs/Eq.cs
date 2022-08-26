using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	public class Eq1<T> :

		nilnul.obj.Box1<IEqualityComparer<T>>
		,
		
		IEqualityComparer<nilnul.ObjsI3<T>>
		,
		IEqualityComparer<IEnumerable<T>>
	{
		

		public Eq1(IEqualityComparer<T> elementEq):base(elementEq)
		{

		}

		public Eq1():this(EqualityComparer<T>.Default)
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


		static public Eq1<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq1<T>>.Instance;
			}
		}

		static public Eq1<byte> _OfBytes {
			get {
				return Eq1<byte>.Singleton;
			}
		}
	}

}
