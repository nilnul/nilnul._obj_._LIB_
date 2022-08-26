using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq
{
	public interface IComp { }
	public interface CompI<TElement>
		:IComparer<IEnumerable<TElement>>
		,
		IComp
	{

	}


	
}
