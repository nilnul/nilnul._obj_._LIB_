using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.eq_
{
	/// <summary>
	/// 'cuz we have only one typPar, so we name it as Defaulted rather than EqDefaulted
	/// </summary>
	public class Defaulted<T, TEq> : co.Eq<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Defaulted() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}
	}
}
