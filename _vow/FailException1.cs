using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._vow
{
	[Serializable]
	public class FailException1<TVow>
		:

		Exception
		where TVow : nilnul.obj.IVow
	{
		public FailException1(string message) : base(message) { }
		public FailException1(string message, Exception inner) : base(message, inner) { }
		protected FailException1(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
		public FailException1()
			: this($"{typeof(TVow).FullName}#.vow failed; See stack for more information, including the vowee.")

		{ }

		//public override string ToString()
		//{
		//	return $"Unacceptable by {typeof(TVow).FullName}:{Message}";
		//}
	}




}
