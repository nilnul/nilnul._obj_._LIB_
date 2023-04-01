using nilnul.obj.re;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.vec.re_
{
	public class _Memberwise_assumesVec<T>
		:
		nilnul.obj.Box_ofIn<
			nilnul.obj.ReI<T>
		>
		,

		vec._ReI_assumesVec<T>
	{
		public _Memberwise_assumesVec(in ReI<T> val) : base(val)
		{
		}

		public _Memberwise_assumesVec(ReI<T> x) : base(x)
		{
		}

		public bool re(IEnumerable<T> a, IEnumerable<T> b)
		{
			return vec.op_.binary_.zip_._MemberAsSingletonX._SeqOfCo_assumesVec_ovHomo(a, b).All(
				c=> boxed.Re(c)
			);

		}
	}
}
