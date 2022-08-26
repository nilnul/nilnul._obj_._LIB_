using System;
using System.Net;

namespace nilnul.obj.duo
{
	


	public interface MergeI<in P, in P1,out R>
		
	{
		R merge(P a, P1 b);

	}


}
