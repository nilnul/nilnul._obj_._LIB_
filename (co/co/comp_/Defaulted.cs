using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.comp_
{
	/// <summary>
	/// </summary>
	public class Neo<T, TComp> : co.Comp<T>
		where TComp : IComparer<T>, new()
	{
		public Neo() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TComp>.Instance
		)
		{
		}
	}
}
