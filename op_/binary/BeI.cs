using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary
{
	public interface BeI<T,TOp>
		:nilnul.obj.BeI1<TOp>
		where TOp: obj.op_.BinaryI<T>
	{
	}

	public interface BeI<T>
		:BeI<T,BinaryI<T>>
	{ }
}
