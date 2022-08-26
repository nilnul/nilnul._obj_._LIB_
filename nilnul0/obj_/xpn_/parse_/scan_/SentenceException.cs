using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_.scan_
{
	/// <summary>
	/// in comparison with word:
	/// 1) word is regex (enumeratable, context free); sentence is type 2(using pattern; context free)
	/// 
	/// </summary>

	[Serializable]
	public class SentenceException : ScanException
	{
		public SentenceException() { }
		public SentenceException(string message) : base(message) { }
		public SentenceException(string message, Exception inner) : base(message, inner) { }
		protected SentenceException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
