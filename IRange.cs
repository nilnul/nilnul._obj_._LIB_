using System;
using System.Linq;

namespace nilnul.obj
{


	[Obsolete(nameof(IBetwixt))]
	public interface IRange:IBetwixt{
		
	}

	public interface IRange<T>:IRange
	{}


}