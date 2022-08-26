using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be.vow_
{
	public class BeDefault< TBe> : obj.expr.be.Vow
		where TBe :BeI1<ExprI4>,new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefault< TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefault< TBe>>.Instance;
			}
		}


	}
}
