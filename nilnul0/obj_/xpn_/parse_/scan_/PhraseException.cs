using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_.scan_
{

	[Serializable]
	public class PhraseException : ScanException
	{
		public PhraseException() { }
		public PhraseException(string message) : base(message) { }
		public PhraseException(string message, Exception inner) : base(message, inner) { }
		protected PhraseException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
