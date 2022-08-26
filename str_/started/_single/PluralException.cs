using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started._single
{
	/// <summary>
	/// more than one so we don't know choose which one.
	/// </summary>

	[Serializable]
	public class PluralException : Exception
	{
		public PluralException() { }
		public PluralException(string message) : base(message) { }
		public PluralException(string message, Exception inner) : base(message, inner) { }
		protected PluralException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
