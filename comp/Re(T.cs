using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp
{
	
	public  class Re<T>
		:IEqualityComparer<T>
	{

		private IComparer<T> _ord;

		public IComparer<T> ord
		{
			get { return _ord; }
			set { _ord = value; }
		}

		public Re(IComparer<T> ord)
		{
			_ord = ord;
		}

		public bool le(T x, T y) {
			return _ord.Compare(x, y)<=0;
		}

		public bool ge(T x, T y) {
			return le(y, x);

		}


		public bool ne(T x, T y) {
			return _ord.Compare(x,y) !=0;

		}

		public bool lt(T x, T y) {
			return _ord.Compare(x,y)<0;

		}

		public bool gt(T x, T y) {
			return _ord.Compare(x,y)>0;

		}
	

		public bool Equals(T x, T y)
		{
			return eq(x, y);

			//throw new NotImplementedException();
		}

		public bool eq(T x, T y)
		{
			return _ord.Compare(x, y) == 0;

			//throw new NotImplementedException();
		}

		public int GetHashCode(T obj)
		{
			
			return 0;
			//throw new NotImplementedException();
		}
	}

	
}
