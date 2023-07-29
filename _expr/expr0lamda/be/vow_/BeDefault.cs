using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.expr0lamda.be.vow_
{

	public class BeDefault< TBe> : obj._expr.expr0lamda.be.Vow
		where TBe :BeI,new()
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
