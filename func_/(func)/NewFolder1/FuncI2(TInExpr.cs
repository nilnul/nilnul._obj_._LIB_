using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete()]
	public interface FuncI3<TPar, TBody>
		:
		_func_.InputI<TPar>
		,
		_func_.OutputI<TBody>
		//where TPar:nilnul.obj.var._sortie_.BlankI
		where TBody : nilnul.obj._expr_.BlankI
		where TPar : nilnul.obj._func._input_.BlankI

	{

	}

	[Obsolete()]
	public interface FuncI_inputSortie<TPar, TBody>
		:
		_func_.input_.SortieI<TPar>
		,
		_func_.OutputI<TBody>
		//where TPar : nilnul.obj._func._input_.BlankI
		where TPar:nilnul.obj._func.input_.SortieI
		where TBody : nilnul.obj._expr_.BlankI
	{

	}

}
