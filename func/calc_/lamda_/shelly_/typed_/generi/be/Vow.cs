using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.typed_.generi.be
{

	public class Vow<TRet>
		:
		nilnul.obj.be.Vow4<
			func.calc_.lamda_.typed_.Generi<TRet>
		>
		,
		func.calc_.lamda_.typed_.generi.VowI<TRet>
	{
		public Vow(BeI1<Generi<TRet>> be) : base(be)
		{
		}

		public Vow(Predicate<Generi<TRet>> predicate) : base(predicate)
		{
		}

		public Vow(Func<Generi<TRet>, bool> func) : base(func)
		{
		}
	}
}
