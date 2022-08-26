using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary._accumulator_
{
	public interface ElEqI< T,TEq>
		:
		nilnul.obj._set_.ElEqI1<T, TEq>
		where TEq:IEqualityComparer<T>
	{
		
	}

	public interface ElEqI< T>
		:
		nilnul.obj._set_.ElEqI1<T>
	{
		
	}
	


}
