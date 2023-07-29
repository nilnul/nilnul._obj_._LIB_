using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj._expr_
{

	public interface ReduceI<out T> {

		T reduce();

	}
}
