using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq_.ovNuly_
{
	/// <summary>
	/// we cannot tell the difference between null. So null must be eq.
	/// make null uneq, and we will make this relation irreflexive; but eqComp requires the relation to be reflexive.
	/// Define NulNe in <see cref="nilnul.obj.re_"/>
	/// </summary>

	[Serializable]
	public class NulNeException : Exception
	{
		public NulNeException() { }
		public NulNeException(string message) : base(message) { }
		public NulNeException(string message, Exception inner) : base(message, inner) { }
		protected NulNeException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

	
}
	/// the hashcode of null is eq. But that doesnot make it wrong, as EqCompare requires same element has same hashcode; different element can or doesnot have same hashCode.
