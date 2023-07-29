using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	

	public interface SetI2< /*out*//*as MemberEq is not covariable*/   TMember> :	
		ISet<TMember>
		,
		
		_set_.MemberEqI<TMember>
		,
		nilnul.ObjsI3<TMember>

	{

	}

	public class Set2<TMember>
		:
		HashSet<TMember>
		,
		SetI2<TMember>
	{
		public Set2() //base uses default eqComparer
		{
		}

		public Set2(int capacity) : base(capacity)
		{
		}

		public Set2(IEqualityComparer<TMember> comparer) : base(comparer)
		{
		}

		public Set2(IEnumerable<TMember> collection) : base(collection)
		{
		}

		public Set2(HashSet<TMember> collection) : base(collection,collection.Comparer)
		{
		}

		public Set2(IEnumerable<TMember> collection, IEqualityComparer<TMember> comparer) : base(collection, comparer)
		{
		}

		public Set2( IEqualityComparer<TMember> comparer, IEnumerable<TMember> collection) : base(collection, comparer)
		{
		}

		public Set2(int capacity, IEqualityComparer<TMember> comparer) : base(capacity, comparer)
		{
		}

		protected Set2(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public IEqualityComparer<TMember> memberEq => base.Comparer;
	}

}
