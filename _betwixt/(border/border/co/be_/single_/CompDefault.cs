using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co.be_.single_
{
	public class CompDefault<T,TBorder,TComp> :
		Single<T,TBorder>
		where TBorder: obj.BorderI<T>
		where TComp:IComparer<T>,new()
	{
		

		public CompDefault()
			:base(


				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<
					 obj.comp.re_.CompDefault<T,TComp>
				>.Instance

		)
		{
		}



		static public CompDefault<T,TBorder,TComp> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CompDefault<T,TBorder,TComp>>.Instance;
			}
		}



	}
}
