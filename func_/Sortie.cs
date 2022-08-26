using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_
{
	public interface InputSortieI<TInput,TOutput>
		:
		_func_.input_.SortieI< TInput>
		,
		_func_.OutputI<TOutput>
		where TInput: _func.input_.SortieI
		where TOutput: obj._expr_.BlankI
	{
	}
}
