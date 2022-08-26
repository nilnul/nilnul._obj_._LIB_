using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._set_.memberEq_
{
	public class EqDefaulted<T, TEq>
		:
		MemberEqA<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefaulted() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}
	}
}
