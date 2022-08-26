using System;

namespace nilnul.obj._call_
{

	[Obsolete()]
	public interface OpI<out TOp>
		//where TOp:nilnul.obj._op_.BlankI
	{
		TOp op { get;  }
	}
}