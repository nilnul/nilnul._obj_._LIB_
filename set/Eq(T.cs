using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set
{
	public class Eq<T>
		
		:
		IEqualityComparer<nilnul.obj.SetI1<T>>
		,
		IEqualityComparer<nilnul.ObjsI2<T>>
		,
		IEqualityComparer<HashSet<T>>
		,
		IEqualityComparer<IEnumerable<T>>


	{
		private IEqualityComparer<T> _objEq;

		public IEqualityComparer<T> objEq
		{
			get { return _objEq; }
			set { _objEq = value;
				_enumerableEq = new eq_.EqOfEnumerable<T>(value);

			}
		}

		private eq_.EqOfEnumerable<T> _enumerableEq;

		public Eq(IEqualityComparer<T> objEq)
		{
			this.objEq = objEq;
		}
		public bool Equals(nilnul.obj.SetI1<T> x, nilnul.obj.SetI1<T> y)
		{

			return  Equals(x as nilnul.ObjsI2<T>,y as nilnul.ObjsI2<T>);
 		}

	

		public int GetHashCode(nilnul.obj.SetI1<T> obj)
		{

			return GetHashCode(obj as nilnul.ObjsI2<T>);

			//throw new NotImplementedException();
		}

		public int GetHashCode(ObjsI2<T> obj)
		{
			return new HashSet<T>(obj.toArr(),_objEq).GetHashCode();

			//throw new NotImplementedException();
		}

		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{
			return _enumerableEq.Equals(x,y);

			//throw new NotImplementedException();
		}

		public bool Equals(ObjsI2<T> x, ObjsI2<T> y)
		{
			return new HashSet<T>(x.toArr(), _objEq ).SetEquals(new HashSet<T>(y.toArr()));

			//throw new NotImplementedException();
		}



		public bool Equals(HashSet<T> x, HashSet<T> y)
		{
			return _enumerableEq.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(HashSet<T> obj)
		{
			return _enumerableEq.GetHashCode(obj);
			//throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<T> obj)
		{
			return 1;
		}
	}
}
