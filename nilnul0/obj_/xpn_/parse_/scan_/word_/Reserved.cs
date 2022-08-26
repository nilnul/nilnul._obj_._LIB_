using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.parse_.scan_.word_
{

	[Serializable]
	public class ReservedException : WordException
	{

		public ReservedException() { }
		public ReservedException(string message) : base(message) { }
		public ReservedException(string message, Exception inner) : base(message, inner) { }
		protected ReservedException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		static public ReservedException OvWord(string word) {
			return new ReservedException($"{word} is reserved");
		}
	}
}
