using System;
using System.Net;

namespace nilnul.obj.duo
{
	public partial interface OpI<T>
		:OpI<T,T,T>
	{

	}


	public partial interface OpI<in P, in P1,out R>
		:OpI
	{
		R eval(P a, P1 b);

	}


}
