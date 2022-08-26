using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re
{
	[Obsolete()]
	public class Converse<T, TRe> : Converse<T>
		where TRe : nilnul.obj.ReI<T>, new()
	{
		public Converse() : base(nilnul.obj.SingletonByLazy<TRe>.Lazy)
		{
		}


		static public Converse<T,TRe> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Converse<T,TRe>>.Instance;
			}
		}

	}
}
