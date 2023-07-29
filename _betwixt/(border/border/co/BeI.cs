using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co
{
	public interface BeI<T,TBorder>
		:nilnul.obj.BeI_ofIn<(TBorder,TBorder)>
		where TBorder: obj.BorderI<T>
	{

	}
}
