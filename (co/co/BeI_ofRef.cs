using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	public interface BeI_ofRef<T,T1>
		:
		nilnul.obj.BeOfRefI< (T,T1)>
	{
	}

	public interface BeI_ofRef<T> : BeI_ofRef<T, T> {

	}


}
