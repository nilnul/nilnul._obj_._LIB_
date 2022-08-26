using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.collection.set
{
	public partial class SetByPredicate<TElement>
		:SetI<TElement>
	{
		private System.Predicate<TElement> _predicate;

		public System.Predicate<TElement> predicate
		{
			get { return _predicate; }
			set { _predicate = value; }
		}
		

		public SetByPredicate(System.Predicate<TElement> p)
		{
		}


		public bool contains(TElement a)
		{
			return predicate(a);
		}
	}
}
