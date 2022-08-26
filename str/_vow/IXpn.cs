using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs._vow
{
	/// <summary>
	/// xpn thrown when vowing an instance of "Objs"
	/// </summary>
	interface IXpn
	{
	}

	[Serializable]
	public class ObjsException : Exception
	{
		public ObjsException() { }
		public ObjsException(string message) : base(message) { }
		public ObjsException(string message, Exception inner) : base(message, inner) { }
		protected ObjsException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
