using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.dense.border.co.be_.dwelt_
{
	public class CompDefault<T, TBorder, TComp>
		:
		Dwelt<T, TBorder>
		where TBorder : obj.BorderI<T>
		where TComp : IComparer<T>,new()
		where T: obj_.IDense
	{
		public CompDefault() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<
				obj.border.co.be_. single_.CompDefault<T,TBorder,TComp>
			 >.Instance
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<
				 obj.border.co.be_.spanned_.CompDefault<T,TBorder,TComp>
			>.Instance
		)
		{
		}


		static public CompDefault<T, TBorder, TComp> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CompDefault<T, TBorder, TComp>>.Instance;
			}
		}

	}
}
