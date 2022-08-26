using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_
{
	public interface IParse { }
	/// <summary>
	/// an exception during the parse phase of nilnul.lang.Build
	/// </summary>

	[Serializable]
	public class ParseException : Exception
		,
		IParse
	{
		public ParseException() { }
		public ParseException(string message) : base(message) { }
		public ParseException(string message, Exception inner) : base(message, inner) { }
		protected ParseException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
