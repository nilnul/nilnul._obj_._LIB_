using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be.vow_
{
	public class BeDefaulted<TEl, TBe>
		:
		nilnul.obj.str_.seq.be.Vow1<TEl>
		where TBe: obj.BeI1<SeqI2<TEl>>,new()
	{
		public BeDefaulted( ) : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}


		static public BeDefaulted<TEl, TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaulted<TEl, TBe>>.Instance;
			}
		}

	}
}
