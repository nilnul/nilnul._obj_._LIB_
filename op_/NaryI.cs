using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	public interface NaryI<out T>
		:
		//_nulary_.RetI<T>
		//, _nary_.BlankI
		//,
		obj.of_.OfEmptyI<T>
		,
		INary<T>

	{
	}

	


}
