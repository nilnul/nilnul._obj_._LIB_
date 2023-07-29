using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.states.be_.sameVars
{
	public class SameVals<T> : BeI_ofDict<T>
	{
		private IEqualityComparer<T> _valEq;

		public IEqualityComparer<T> valEq
		{
			get { return _valEq; }
			set {
				_valEq = value;
				_sameVals = new state.eq_.sameVars.SameVals<T>(value);

			}
		}



		private nilnul.obj.var.set.state.eq_.sameVars.SameVals<T> _sameVals;

		public nilnul.obj.var.set.state.eq_.sameVars.SameVals<T> sameVals
		{
			get { return _sameVals; }
			//set { _sameVals = value; }
		}


		public SameVals(IEqualityComparer<T> valEq)
		{
			this.valEq = valEq;
		}

		public bool _be(IEnumerable<State_heritDict<T>> obj) {


				if (obj.Any())
				{
					var skipped = obj.Skip(1);
					return skipped.All(
						x=>  _sameVals._Equals(x, obj.First())
					);

				}
				return true;


		}

		public bool be(IEnumerable<State_heritDict<T>> obj)
		{

			if (SameVars_ofDict<T>.Lazy.be(obj)) {

				return _be(obj);
			}

			return false;

			//throw new NotImplementedException();
		}
	}
}
