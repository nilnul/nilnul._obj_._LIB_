using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj_.xpn_;

namespace nilnul.obj.vow_
{
	/// <summary>
	/// this guy is cynical and is not satifiable with anything.
	/// </summary>
	/// 
	[Obsolete(nameof(xpn_.UnacceptableA<T>))]
	public abstract class XpnA<T>:nilnul.obj.VowA1<T,nilnul.obj_.xpn_.UnacceptableException>
	{
		/// <summary>
		/// if this instance is used repeatedly, then its instantiation will be efficiency for you don't have to re-instantiate everytime 
		/// </summary>
		/// <param name="exceptionMsg"></param>
		public XpnA(string exceptionMsg):base(new obj_.xpn_.UnacceptableException(exceptionMsg))
		{
		}
		
		public XpnA():this("")
		{
		}

		public XpnA(UnacceptableException xpn) : base(xpn)
		{
		}
	}

	[Obsolete(nameof(xpn_.unacceptable_.OfVowA<T,TVow>))]
	public abstract class XpnA<T,TVow>
		:
		nilnul.obj.VowA1<T,nilnul.obj_.xpn_.UnacceptableException<TVow>>
		where TVow: nilnul.obj._vow_.BlankI
	{
		/// <summary>
		/// if this instance is used repeatedly, then its instantiation will be efficiency for you don't have to re-instantiate everytime 
		/// </summary>
		/// <param name="exceptionMsg"></param>
		public XpnA(string exceptionMsg):base(new obj_.xpn_.UnacceptableException<TVow>(exceptionMsg))
		{
		}
		
		public XpnA():this("")
		{
		}

		public XpnA(UnacceptableException<TVow> xpn) : base(xpn)
		{
		}
	}
}
