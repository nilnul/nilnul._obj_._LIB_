using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.state.eq_.sameVars
{
	public class SameVals<T> :
		
		nilnul.obj.var.set.state.EqI_ofDict<T>
	{
		private IEqualityComparer<T> _valEq;

		public IEqualityComparer<T> valEq
		{
			get { return _valEq; }
		//	set { _valEq = value; }
		}

		public SameVals(IEqualityComparer<T> valEq)
		{
			_valEq = valEq;
		}

		public bool Equals(State_heritDict<T> x, State_heritDict<T> y)
		{
			return eq_.SameVars_ofDict<T>.Lazy.Equals(x, y) 
				&&
				x.Keys.All(var => _valEq.Equals(x[var] ,y[var] ));

			//throw new NotImplementedException();
		}

		public bool _Equals(State_heritDict<T> x, State_heritDict<T> y)
		{
			return 
				x.Keys.All(var => _valEq.Equals(x[var] ,y[var] ));

			//throw new NotImplementedException();
		}


		public int GetHashCode(State_heritDict<T> obj)
		{
			return 0;
			throw new NotImplementedException();
		}

		

	}
}
