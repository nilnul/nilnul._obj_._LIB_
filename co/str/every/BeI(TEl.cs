using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.str.every
{
	public interface BeI<TEl>:
		nilnul.obj.str.every.BeI<
			(TEl,TEl)>
	{
	}
}
