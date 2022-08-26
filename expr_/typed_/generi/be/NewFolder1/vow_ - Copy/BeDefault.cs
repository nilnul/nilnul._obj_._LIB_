using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be.vow_
{
	public class BeDefault<T, TBe> : obj.expr.be.Vow<T>
		where TBe :BeI1<ExprI_sys<T>>,new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefault<T, TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefault<T, TBe>>.Instance;
			}
		}


	}
}
