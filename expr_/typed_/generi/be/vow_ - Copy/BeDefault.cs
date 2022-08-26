using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi.be.vow_
{
	public class BeDefault<T, TBe> : obj.expr_.typed_.generi.be.Vow<T>
		where TBe :BeI1<GeneriI<T>>,new()
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
