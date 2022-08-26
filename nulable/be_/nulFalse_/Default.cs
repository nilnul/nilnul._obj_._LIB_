using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.nulable.be_.nulFalse_
{
	public class Default<T, TBe> 
		:
		nilnul.obj.nulable.be_.NulFalse<T,TBe>
		where TBe : nilnul.obj.BeI1<T>,new()
	{
		public Default() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		static public Default<T, TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Default<T, TBe>>.Instance;
			}
		}
	}
}
