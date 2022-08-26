using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.comp_
{
	public class CompDefault<TElement,TComp>
		:
		seq.Comparer<TElement>
		,
		CompI<TElement>
		

		where TComp:IComparer<TElement>,new()
	{
		public CompDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComp	>.Instance)
		{
		}


		static public CompDefault<TElement,TComp> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CompDefault<TElement,TComp>>.Instance;
			}
		}


	}
}
