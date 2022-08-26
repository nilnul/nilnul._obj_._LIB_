using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.vow_._started
{

	[Serializable]
	public class NoneException : Exception
	{
		public NoneException() { }
		public NoneException(string message) : base(message) { }
		public NoneException(string message, Exception inner) : base(message, inner) { }
		protected NoneException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
