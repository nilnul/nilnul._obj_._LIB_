using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ.ns_.dwelt.seg_.nonhead_.xpN_
{

	[Serializable]
	public class NilnulException : Exception
	{
		public NilnulException():this(
			"nilnul can only appear as the first seg."
		) { }
		public NilnulException(string message) : base(message) { }
		public NilnulException(string message, Exception inner) : base(message, inner) { }
		protected NilnulException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
