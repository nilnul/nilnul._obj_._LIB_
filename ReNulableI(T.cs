using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	 

	public interface ReNulableI<T>
	{
		bool? reNulable(T a,T b);
	}
}
