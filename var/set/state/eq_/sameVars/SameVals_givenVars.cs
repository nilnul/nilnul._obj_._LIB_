using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.state.eq_.sameVars
{
	public class SameVals_givenVars<T>

		:IEqualityComparer<State_heritDict<T>>
		
	
	{
		private IEqualityComparer<T> _valEq;

		public IEqualityComparer<T> valEq
		{
			get { return _valEq; }
		//	set { _valEq = value; }
		}

		private nilnul.obj.var.Set<T> _vars;

		public nilnul.obj.var.Set<T> vars
		{
			get { return _vars; }
			set { _vars = value; }
		}


		public SameVals_givenVars(
			nilnul.obj.var.Set<T> vars
			,
			IEqualityComparer<T> valEq

			)
		{
			_valEq = valEq;
			_vars = vars;
		}

	

		public bool Equals(State_heritDict<T> x, State_heritDict<T> y)
		{
			return _vars.All( var=>_valEq.Equals(x[var] ,y[var] ));

			//throw new NotImplementedException();
		}


		public int GetHashCode(State_heritDict<T> obj)
		{
			return 0;
			//throw new NotImplementedException();
		}


	}
}
