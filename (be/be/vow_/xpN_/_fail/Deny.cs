using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_.xpN_._fail
{


	[Obsolete(nameof(nilnul.obj.be._vow.xpn_.NegativeException<T>))]

	[Serializable]
	public class FailException<T, TBe> : nilnul.obj._vow.FailException<nilnul.obj.be.VowI<T, TBe>>
		where TBe : nilnul.obj.BeI1<T>
	{

		public FailException() : this(
$"{typeof(TBe).FullName}() failed"
			)
		{ }

		
		public FailException(string message) : base(message) { }
		public FailException(string message, Exception inner) : base(message, inner) { }
		protected FailException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		public void throws()
		{
			throw this;
			//throw new NotImplementedException();
		}


	}
}
