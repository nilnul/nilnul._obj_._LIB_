using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.uni.be
{

	public class Vow
		:
		nilnul.obj.be.Vow4<
			func_.Uni
		>
		,
		func_.uni.VowI
	{
		public Vow(BeI1<func_.Uni> be) : base(be)
		{
		}

		public Vow(Predicate<func_.Uni> predicate) : base(predicate)
		{
		}

		public Vow(Func<func_.Uni, bool> func) : base(func)
		{
		}
	}
}
