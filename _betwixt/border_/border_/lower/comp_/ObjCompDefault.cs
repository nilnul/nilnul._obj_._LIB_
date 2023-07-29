using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border_.lower.comp_
{
	public class ObjCompDefault<T, TBorder, TObjComp>
		:
		nilnul.obj.border.comp_.Lower<T, TBorder>
		where TBorder : nilnul.obj.BorderI<T>
		where TObjComp : IComparer<T>, new()
	{
		public ObjCompDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TObjComp>.Instance
		)
		{
		}

		static public ObjCompDefault<T, TBorder, TObjComp> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ObjCompDefault<T, TBorder, TObjComp>>.Instance;
			}
		}

	}
}
