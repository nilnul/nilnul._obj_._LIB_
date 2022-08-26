using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj._typ._ns.seg_.xpN_
{

	/// <summary>
	/// eg:
	///		t
	///			in
	///				nilnul.t.SomeType
	///	Regard this as exception, such as to be reported and let the caller to process (the caller can then delete it or ignore it)
	/// </summary>

	[Serializable]
	public class SegIsTmpException : Exception
		,ITmp
	{

		public SegIsTmpException():this(
			"Namespace is supposed to be not temp but persistant; so each seg must have a term, which possesses at least two letters."
		)
		{ }
		public SegIsTmpException(string message) : base(message) { }
		public SegIsTmpException(string message, Exception inner) : base(message, inner) { }
		protected SegIsTmpException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
