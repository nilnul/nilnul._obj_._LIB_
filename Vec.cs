using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	public interface VecI<T> :IVec
		//,
		//_rec_.ArityI
		,
		IEnumerable<T>
	{

	}

	/// <summary>
	/// co, two letters, means a vec of two component
	/// tro, three letters, means a vec of three component
	/// quod, four letters, means a vec of four component
	/// uno, for which we cannot use one letter as [nilnul.dev] reserves one letter for local temp use, uses one more letter than co, so we settle with uno
	/// nino, or nono, two letters less than co, means a vec of nil component.
	/// </summary>
	public interface Vec_I {

	}
}
