using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.type
{
	public partial class TypeWithPredicate<PredicateSingleton,T>
		where PredicateSingleton:nilnul_obj.bit.Predicate<T>
	{
		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		

		public TypeWithPredicate(T value)
		{
			Singleton<nilnul_obj.bit.Predicate<T>>.Instance.assert(value);
			this.val = value;
		}
					

	}
}
