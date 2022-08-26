using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be._vow.xpn_
{

	[Serializable]
	public class Negative1Exception<T> : False1Exception<T,nilnul.obj.IBe<T>>
	{
		public Negative1Exception(nilnul.obj.IBe<T> be, T obj):base(be, obj) {

		}
		[Obsolete()]
		public Negative1Exception(string message) : base(message) { }
		[Obsolete()]
		public Negative1Exception(string message, Exception inner) : base(message, inner) { }
		[Obsolete()]
		protected Negative1Exception(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

}
