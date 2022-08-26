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

	[Serializable]
	public class FuncException : ScanException
	{
		public FuncException() { }
		public FuncException(string message) : base(message) { }
		public FuncException(string message, Exception inner) : base(message, inner) { }
		protected FuncException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
