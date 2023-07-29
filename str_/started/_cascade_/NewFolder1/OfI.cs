using System.Collections.Generic;

namespace nilnul.objs_.started._cascade_
{
	public interface OfSeqI<T>
	{
		T cascade(IEnumerable<T> seq);
		
	}
	public interface OfParamsI<T>
	{
		T cascade(params T[] seq);
	}

	public interface OfStartedI<T>
	{
		T cascade(Started3<T> started);
	}


}