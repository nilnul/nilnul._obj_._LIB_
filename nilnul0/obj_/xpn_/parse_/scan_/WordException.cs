using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_.scan_
{

	[Serializable]
	public class WordException : ScanException
	{
		public WordException() { }
		public WordException(string message) : base(message) { }
		public WordException(string message, Exception inner) : base(message, inner) { }
		protected WordException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
