using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.algebra_.cobiop_.semiring_.dwelt_.rng_.ring_.plural_
{
	/// <summary>
	/// </summary>
	/// if nil and 1 are the same element.
	///		for nonnil x,
	///			1*x = x
	///			but 1 is 0, so 1*x=0*x = 0, so x=0. a contradiction.
	///		so nil and 1 must not be the same.
	/// 

	[Serializable]
	public class NilIsOneException : Exception
	{
		public NilIsOneException() { }
		public NilIsOneException(string message) : base(message) { }
		public NilIsOneException(string message, Exception inner) : base(message, inner) { }
		protected NilIsOneException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
