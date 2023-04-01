using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj_.xpn_;

namespace nilnul.obj.vow_.xpn_.unacceptable_
{
	

	public abstract class OfVowA<T,TVow>
		:
		nilnul.obj.VowA1<T,nilnul.obj_.xpn_.UnacceptableException<TVow>>
		where TVow: nilnul.obj._vow_.BlankI
	{
		/// <summary>
		/// if this instance is used repeatedly, then its instantiation will be efficiency for you don't have to re-instantiate everytime 
		/// </summary>
		/// <param name="exceptionMsg"></param>
		public OfVowA(string exceptionMsg):base(new obj_.xpn_.UnacceptableException<TVow>(exceptionMsg))
		{
		}
		
		public OfVowA():this("")
		{
		}

		public OfVowA(UnacceptableException<TVow> xpn) : base(xpn)
		{
		}
	}
}
