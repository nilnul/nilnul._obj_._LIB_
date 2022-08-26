using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface Vow_ofRefI<T>:IVow
	{
		void vow(ref T obj);
	}

	
}
