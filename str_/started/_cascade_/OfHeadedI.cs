using System.Collections.Generic;

namespace nilnul.obj.str_.started._cascade_
{
	public interface OfHeadedI<T>
	{
		T cascade(T head, IEnumerator<T> seq);

	}



}