using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be
{
	[Obsolete(nameof(be.vow_.BeDefaulted<T,TBe>))]
	public class Vow<T, TBe> : nilnul.obj.seq.VowI<T>
		where TBe:nilnul.obj.seq.BeI<T>,new()
	{
		public void vow(IEnumerable<T> obj)
		{
			nilnul.bit.vow_.True.Singleton.vow(
				nilnul.obj_.Singleton<TBe>.Instance.be(obj)
			);
		}

		static public Vow<T,TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow<T,TBe>>.Instance;
			}
		}

	}


}
