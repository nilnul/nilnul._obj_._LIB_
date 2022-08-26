using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.comp
{
	public class Re<T,TBorder, TComp>
		:nilnul.obj.comp.Re<TBorder,TComp>
		where TComp:IComparer<TBorder>,new()
		where TBorder:nilnul.obj.BorderI<T>
	{

	}
}
