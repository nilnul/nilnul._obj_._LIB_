using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.str_.enumerable.be_
{
	[Obsolete(nameof(nilnul.obj.str.be_._DistinctX))]
	public  class Distinct_eqDefault<TElement, TEq>
		: Distinct<TElement,TEq>
		
		where TEq : IEqualityComparer<TElement>,new()
	{

		static public Distinct_eqDefault<TElement, TEq> Singleton = SingletonByDefault<Distinct_eqDefault<TElement, TEq>>.Instance;

		public Distinct_eqDefault():base(SingletonByDefault<TEq>.Instance)
		{

		}

		public class En :
			nilnul.obj.be.En_beDefaultable<IEnumerable<TElement>,Distinct_eqDefault<TElement,TEq>>
			
			
		{

			public En(IEnumerable<TElement> val) : base(val)
			{

			}
		}


	}



	public  class Distinct<TElement,TEq>
		:nilnul.obj.BeI<IEnumerable<TElement>>
		where TEq:IEqualityComparer<TElement>
	{
		

		private TEq _eq;

		public TEq eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public Distinct(TEq eq)
		{
			_eq = eq;

		}



		public bool _be(IEnumerable<TElement> s_distinct, TElement a) {
			return s_distinct.All(
				x=> !eq.Equals(x, a)	
			);
		}

		public bool be(IEnumerable<TElement> obj)
		{

			if (obj.Count()==0)
			{
				return true;
			}
			var head = obj.First();

			var tail = obj.Skip(1);
			return  be(tail) && _be(tail, head);

			//throw new NotImplementedException();
		}
		



	}



}
