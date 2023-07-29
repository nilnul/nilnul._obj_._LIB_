using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.set.assigns.be_;

namespace nilnul.obj.var.set.assigns_.sameVars.be_
{
	/// <summary>
	/// for sameVars, is it dif in values?
	/// </summary>
	public class Dif<T>
		:
		nilnul.obj.var.set.assigns_.sameVars.BeI<T>
	{
		private Contain<T> _contain;

		public Contain<T> contain
		{
			get { return _contain; }
			set { _contain = value; }
		}
		public Dif(IEqualityComparer<T> valEq)
		{
			_contain = new be_.Contain<T>(valEq);

		}

		public bool be(SameVars<T>.En obj)
		{
			if (obj.avowed.Any())
			{
				var skipped = obj.avowed.Skip(1);
				return _be(obj.avowed.Skip(1)) && _contain._eval_allSameVars(skipped, obj.avowed.First());

			}
			return true;

			//throw new NotImplementedException();
		}

		public bool _be(IEnumerable<State<T>> obj) {

			if (obj.Any())
			{
				var skipped = obj.Skip(1);
				return _be(skipped) && _contain._eval_allSameVars(skipped, obj.First());

			}
			return true;

		}
	}
}
