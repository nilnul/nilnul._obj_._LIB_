using System.Collections.Generic;

namespace nilnul.obj.str._scala_
{
	public interface OfSeqI<T>
	{
		T scala(IEnumerable<T> seq);
		
	}

	public interface OfParamsI<T>
	{
		T scala(params T[] seq);
	}


	



}