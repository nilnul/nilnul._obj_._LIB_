using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_.scan_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <seealso cref="nameof(Procedure)"/>
	/// </remarks>

	[Serializable]
	public class ProgException : ScanException
	{
		public ProgException() { }
		public ProgException(string message) : base(message) { }
		public ProgException(string message, Exception inner) : base(message, inner) { }
		protected ProgException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
