using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co.be.vow_
{
	public class BeDefault<T,TBorder, TBe>
		:
		Vow<T,TBorder>
		where TBe: nilnul.obj.BeI_ofIn<(TBorder,TBorder)>,new()
		where TBorder: nilnul.obj.BorderI<T>
	{
		public BeDefault() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance

		)
		{
		}

		static public BeDefault<T,TBorder, TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<T,TBorder, TBe>>.Instance;
			}
		}

	}
}
