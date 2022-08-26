using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_.scan_
{

	[Serializable]
	public class CharException : ScanException
	{
		public CharException() { }
		public CharException(int i, char c):this($"char #{i}:{c} is invalid")
		{

		}
		public CharException(string message) : base(message) { }
		public CharException(string message, Exception inner) : base(message, inner) { }
		protected CharException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
