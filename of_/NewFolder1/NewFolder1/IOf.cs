using System;

namespace nilnul.obj
{


	[Obsolete(nameof(IOf1<T>) +" is preferred; the initial typePar shall be the returned type; ")]
	public interface IOf<in T>
		:
		IOf
		,
		IOp<object,T>
		//,
		//_of.IAsTgt<object>
		//,
		//nilnul.obj.op_.IOf
	{

	}


	

}
