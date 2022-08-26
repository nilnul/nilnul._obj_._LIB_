using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be._vow.xpn_
{

	[Serializable]
	public class NegativeException<T> : FalseException<T,nilnul.obj.BeI1<T>>
	{
		public NegativeException(nilnul.obj.BeI1<T> be, T obj):base(be, obj) {

		}
		[Obsolete()]
		public NegativeException(string message) : base(message) { }
		[Obsolete()]
		public NegativeException(string message, Exception inner) : base(message, inner) { }
		[Obsolete()]
		protected NegativeException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

}
