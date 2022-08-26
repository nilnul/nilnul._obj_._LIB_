using System;
using System.Net;

namespace nilnul.obj.duo
{
	


	public interface ZipI<in P, in P1,out R>
		
	{
		R zip(P a, P1 b);

	}


}
