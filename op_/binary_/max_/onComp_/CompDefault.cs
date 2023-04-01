using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.max_.onComp_
{
	public class CompDefault<T, TComp>
		:
		OnComp<T>
		where TComp : IComparer<T>, new()
	{
	
		public CompDefault() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComp>.Instance
		)
		{
		}


		static public CompDefault<T, TComp> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CompDefault<T, TComp>>.Instance;
			}
		}

	}
}
