using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be._vow.xpn_
{
	

	[Obsolete()]
	[Serializable]
	public class DenyException<T, TBe> : Exception, nilnul.obj_.XpnI
		where TBe:nilnul.obj.BeI1<T>
	{
		public DenyException() { }
		public DenyException(string message) : base(message) { }
		public DenyException(string message, Exception inner) : base(message, inner) { }
		protected DenyException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		public void throws()
		{
			throw this;
			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"Unacceptable by vowing the truthfulness of {typeof(TBe).FullName}:{Message}";
		}
	}
}
