using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_.scan_
{

	[Serializable]
	public class ByteException : ScanException
	{
		public ByteException() { }
		public ByteException(string message) : base(message) { }
		public ByteException(string message, Exception inner) : base(message, inner) { }
		protected ByteException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
