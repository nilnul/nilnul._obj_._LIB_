using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_.scan_
{

	[Serializable]
	public class ClauseeException : ScanException
	{
		public ClauseeException() { }
		public ClauseeException(string message) : base(message) { }
		public ClauseeException(string message, Exception inner) : base(message, inner) { }
		protected ClauseeException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
