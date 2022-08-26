using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ._ns._seg._nom.term_.xpN_
{


	/// <summary>
	/// a nom can be a term or a temp, but not both
	/// </summary>
	/// alias:
	///		use "was" to express what doesnot happen.

	[Serializable]
	public class TermWasTempException : Exception
		,
		nom_.ITmp
	{

		public TermWasTempException():this(
			"a nom can be a term or a temp, but not both."
		)
		{ }
		public TermWasTempException(string message) : base(message) { }
		public TermWasTempException(string message, Exception inner) : base(message, inner) { }
		protected TermWasTempException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	class Tmp
	{
	}
}
