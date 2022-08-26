using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.eq_
{


	public class OfCouple<T>
		: IEqualityComparer<Tuple<T, T>>
	{
		private IEqualityComparer<T> _componentEq;

		public IEqualityComparer<T> componentEq
		{
			get { return _componentEq; }
			set { _componentEq = value; }
		}

		

		public OfCouple(
			IEqualityComparer<T> componentEq
		)
		{
			_componentEq = componentEq;
		}



		public bool Equals(Tuple<T, T> x, Tuple<T, T> y)
		{
			return componentEq.Equals(x.Item1, y.Item1) && componentEq.Equals(x.Item2, y.Item2);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Tuple<T, T> obj)
		{
			return componentEq.GetHashCode(obj.Item1)
				&
				componentEq.GetHashCode(obj.Item2);

			//throw new NotImplementedException();
		}
	}



	

}
