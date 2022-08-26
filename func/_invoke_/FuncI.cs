using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func._invoke_
{
	public interface FuncI<TFunc>
		where TFunc:nilnul.obj._func_.BlankI
	{
		TFunc func { get; }
	}
}
