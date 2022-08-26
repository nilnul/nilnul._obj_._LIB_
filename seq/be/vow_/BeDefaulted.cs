using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be.vow_
{
	public class BeDefaulted<T, TBe> : nilnul.obj.seq.be.Vow_beDynamic<T>

		where TBe:nilnul.obj.seq.BeI<T>,new()
	{
		public BeDefaulted() : base(nilnul.obj_.Singleton< TBe>.Instance)
		{
		}

	

		static public BeDefaulted<T,TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefaulted<T,TBe>>.Instance;
			}
		}

	}


}
