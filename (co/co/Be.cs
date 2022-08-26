using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	public interface BeI<T,T1>
		:
		nilnul.obj.BeI1< (T,T1)>
	{
	}

	public interface BeI<T> : BeI<T, T> {

	}


}
