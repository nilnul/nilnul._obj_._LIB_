using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assigns_.sameVars.be_
{
	public class Contain<T>

	{
		private nilnul.obj.var.set.assign.duo_.sameVars.be_.Reflex_bySetAssignEq<T> _duoReflex;

		public nilnul.obj.var.set.assign.duo_.sameVars.be_.Reflex_bySetAssignEq<T> duoReflex
		{
			get { return _duoReflex; }
			//set { _duoReflex = value; }
		}


		public Contain( IEqualityComparer<T> valEq )
		{
			_duoReflex = new assign.duo_.sameVars.be_.Reflex_bySetAssignEq<T>(valEq);
		}

		public bool _eval_allSameVars(
			nilnul.obj.var.set.assigns.be_.SameVars<T>.En assignsSameVars,
			nilnul.obj.var.set.State<T> assignment_sameVars
		) {

			return assignsSameVars.avowed.Any(
				x => _duoReflex.be(x,assignment_sameVars)
			);

		}


	public bool _eval_allSameVars(
			IEnumerable<nilnul.obj.var.set.State<T>> assignsSameVars,
			nilnul.obj.var.set.State<T> assignment_sameVars
		) {

			return assignsSameVars.Any(
				x => _duoReflex.be(x,assignment_sameVars)
			);

		}
		
	}
}
