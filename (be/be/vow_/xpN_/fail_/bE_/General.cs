using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.be.vow_.xpN_._fail;

namespace nilnul.obj.be.vow_.xpN_.fail_.bE_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// for inheritators, the vow of be shall be placed after the namespace segment of "be", for in this way, it illustrates the fact that "vow" is constrcuted on "b", which is different from other "vow" that may be unfounded on "be", but, for examples has its own implementation logic.
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.obj.be.Vow4<T>))]

	public class General<T>
		:xpN_.Fail<T, nilnul.obj.BeI1<T>>

	{
		

		public General(nilnul.obj.BeI1<T> be):base(be)
		{
		}
		public General(nilnul.obj.BeI1<T> be,string msg):base(be, msg)
		{
			
		}

		public General(BeI1<T> be, FailException<T, BeI1<T>> xpn) : base(be, xpn)
		{
		}
	}
	

}