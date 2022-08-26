using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._set_
{
	public interface ElEqI1<T, TEq>
		where TEq:IEqualityComparer<T>
	{
		TEq elEq { get; }


	}

	public interface ElEqI1<T>
		:ElEqI1<T,IEqualityComparer<T>>

	{ }

}
