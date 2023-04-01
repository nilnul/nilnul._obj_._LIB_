using System;

namespace nilnul.obj
{
	

	public interface IOf<TSrc>
		:
		IOf
		,
		_of.IAsTgt<object>
	{ }

}
