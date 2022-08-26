using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp_
{
	public interface OvNulyI<T>
		:IComparer<T>
	{

	}

	public interface NulyOvStructI<T>
		:
		//IComparer<T?>
		//,
		OvNulyI<T?>
		where T:struct
	{

	}

}
