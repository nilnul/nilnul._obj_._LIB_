using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.set.assign.duo.be_;

namespace nilnul.obj.var.set.assign.duo_.sameVars.be_
{
	/// <summary>
	/// 
	/// two setAssignments of sameVars. Are they eq?
	/// We compare the two sets
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Reflex_bySetAssignEq<T>
		: nilnul.obj.BeI<
			nilnul.obj.var.set.assign.duo.be_.SameVars<T>.En
		>
	{
		

		private nilnul.obj.var.set.assign.Eq<T> _varsAssignmentEq;

		public nilnul.obj.var.set.assign.Eq<T> setEq
		{
			get { return _varsAssignmentEq; }
		//	set { _setEq = value; }
		}


		public Reflex_bySetAssignEq( IEqualityComparer<T> valEq)
		{
			//_valEq = valEq;

			_varsAssignmentEq =new  nilnul.obj.var.set.assign.Eq<T>(
				(valEq)	
			);
		}

		public bool be(SameVars<T>.En obj)
		{
			return _varsAssignmentEq.Equals(obj.avowed.Item1, obj.avowed.Item2);

			//throw new NotImplementedException();
		}

		public bool be(nilnul.obj.var.set.State<T> a, nilnul.obj.var.set.State<T> b)
		{
			return _varsAssignmentEq.Equals(
				a,b	
			);
		}
	}
}
