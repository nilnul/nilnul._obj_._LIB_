using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re.complement_
{
	
	public class ReDefault<T, TRe> : Complement<T>
		where TRe : nilnul.obj.ReI<T>, new()
	{
		public ReDefault() : base(nilnul.obj_.Singleton<TRe>.Instance)
		{
		}


		static public ReDefault<T,TRe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ReDefault<T,TRe>>.Instance;
			}
		}

	}
}
