using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_
{

	[Serializable]
	public class ScanException : ParseException
	{
		public ScanException() { }
		public ScanException(string message) : base(message) { }
		public ScanException(string message, Exception inner) : base(message, inner) { }
		protected ScanException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
