using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.reps_.nonpars_
{
	/// <summary>
	///		
	/// </summary>

	[Serializable]
	public class NonbodiedException : Exception
	{
		public NonbodiedException() { }
		public NonbodiedException(string message) : base(message) { }
		public NonbodiedException(string message, Exception inner) : base(message, inner) { }
		protected NonbodiedException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
