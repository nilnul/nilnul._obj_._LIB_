using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj_.xpn_;

namespace nilnul.obj.vow_.xpn_
{
	/// <summary>
	/// this guy is cynical and is not satifiable with anything.
	/// </summary>
	public abstract class UnacceptableA<T>:nilnul.obj.VowA1<T,nilnul.obj_.xpn_.UnacceptableException>
	{
		/// <summary>
		/// if this instance is used repeatedly, then its instantiation will be efficiency for you don't have to re-instantiate everytime 
		/// </summary>
		/// <param name="exceptionMsg"></param>
		public UnacceptableA(string exceptionMsg):base(new obj_.xpn_.UnacceptableException(exceptionMsg))
		{
		}
		
		public UnacceptableA():this("")
		{
		}

		public UnacceptableA(UnacceptableException xpn) : base(xpn)
		{
		}
	}

	
}
