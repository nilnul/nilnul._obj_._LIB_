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
	public class Reflex<T>
		: nilnul.obj.BeI<
			nilnul.obj.var.set.assign.duo.be_.SameVars<T>.En
		>
	{
		//private IEqualityComparer<T> _valEq;

		//public IEqualityComparer<T> valEq
		//{
		//	get { return _valEq; }
		//	set { _valEq = value; }
		//}

		private nilnul.obj.set.eq_.EqOfEnumerable<nilnul.obj.var.Assignment<T>> _setEq;

		public nilnul.obj.set.eq_.EqOfEnumerable<nilnul.obj.var.Assignment<T>> setEq
		{
			get { return _setEq; }
		//	set { _setEq = value; }
		}


		public Reflex( IEqualityComparer<T> valEq)
		{
			//_valEq = valEq;

			_setEq = new obj.set.eq_.EqOfEnumerable<nilnul.obj.var.Assignment<T>>(
				new nilnul.obj.var.assign.Eq<T>(valEq)	
			);
		}

		public bool be(SameVars<T>.En obj)
		{
			return _setEq.Equals(obj.avowed.Item1.avowed, obj.avowed.Item2.avowed);

			//throw new NotImplementedException();
		}
	}
}
