using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.op_
{
	public interface  IBinary
		:nilnul.obj.op_.IBinary<obj.IFunc>
		,
		func.IOp
	{
	}
}
