using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni.be
{

	public class Vow
		:
		nilnul.obj.be.Vow4<
			func.calc_.lamda_.shelly_.Uni
		>
		,
		func.calc_.lamda_.uni.VowI
	{
		public Vow(BeI1<func.calc_.lamda_.shelly_.Uni> be) : base(be)
		{
		}

		public Vow(Predicate<func.calc_.lamda_.shelly_.Uni> predicate) : base(predicate)
		{
		}

		public Vow(Func<func.calc_.lamda_.shelly_.Uni, bool> func) : base(func)
		{
		}
	}
}
