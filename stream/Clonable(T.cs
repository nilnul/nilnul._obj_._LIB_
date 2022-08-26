using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream
{
	public interface ClonableI<T>
		:
		nilnul.obj.StreamI1<T>
		,
		nilnul.obj.ClonableI<
			nilnul.obj.StreamI1<T>
		>
	{

	}
}
