using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq
{
	public  class Re<T>
	{

		private IEqualityComparer<T> _ord;

		public IEqualityComparer<T> ord
		{
			get { return _ord; }
			set { _ord = value; }
		}

		public Re(IEqualityComparer<T> ord)
		{
			_ord = ord;
		}

		


		public bool ne(T x, T y) {
			return !_ord.Equals(x,y) ;

		}

		
	

		public bool eq(T x, T y)
		{
			return _ord.Equals(x, y) ;

			//throw new NotImplementedException();
		}

	
	}

	
}
