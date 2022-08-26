using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict
{
	[Obsolete("nilnul.rel_.Dict, in that dict is the relation based on set.")]

	public interface BeI<TKey,TVal>:nilnul.obj.BeI<Dictionary<TKey,TVal>>
	{
	}
}
