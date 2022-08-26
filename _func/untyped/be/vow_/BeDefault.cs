using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func.untyped.be.vow_
{
	public class BeDefault_ofLambda< TBe> : obj._func.untyped.be.Vow_ofLambda
		where TBe :BeI_ofLambda,new()
	{
		public BeDefault_ofLambda() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefault_ofLambda< TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefault_ofLambda< TBe>>.Instance;
			}
		}


	}
}
