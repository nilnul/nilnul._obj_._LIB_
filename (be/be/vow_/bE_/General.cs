using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.obj.be.Vow4<T>))]

	public class General<T,TXpn>
		:nilnul.obj.be.Vow3<T, nilnul.obj.BeI1<T>, TXpn>

		where TXpn:Exception
	{
		public General(nilnul.obj.BeI1<T> be,TXpn msg):base(be, msg)
		{
			
		}
	}
}