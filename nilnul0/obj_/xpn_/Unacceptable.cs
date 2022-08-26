using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_
{
	[Serializable]
	public class UnacceptableException<TVow> 
		:

		Exception
		where TVow:nilnul.obj._vow_.BlankI
	{
		public UnacceptableException() { }
		public UnacceptableException(string message) : base(message) { }
		public UnacceptableException(string message, Exception inner) : base(message, inner) { }
		protected UnacceptableException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		public override string ToString()
		{
			return $"Unacceptable by {typeof(TVow).FullName}:{Message}";
		}
	}

	[Serializable]
	public class UnacceptableException : XpnAbstractException
		
	{
		public UnacceptableException() { }
		public UnacceptableException(string message) : base(message) { }
		public UnacceptableException(string message, Exception inner) : base(message, inner) { }
		protected UnacceptableException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		
	}

	
}
