using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._vow
{
	[Serializable]
	[Obsolete()]
	public class FailException<TVow>
		:

		Exception
		where TVow : nilnul.obj._vow_.BlankI
	{
		public FailException(string message) : base(message) { }
		public FailException(string message, Exception inner) : base(message, inner) { }
		protected FailException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
		public FailException()
			: this($"{typeof(TVow).FullName}#.vow failed")

		{ }

		//public override string ToString()
		//{
		//	return $"Unacceptable by {typeof(TVow).FullName}:{Message}";
		//}
	}




}
