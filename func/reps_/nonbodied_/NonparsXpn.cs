using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.reps_.nonbodied_
{
	/// <summary>
	/// some body reps are not pars.
	/// </summary>

	[Serializable]
	public class FreeException : Exception
	{
		public FreeException() { }
		public FreeException(string message) : base(message) { }
		public FreeException(string message, Exception inner) : base(message, inner) { }
		protected FreeException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
