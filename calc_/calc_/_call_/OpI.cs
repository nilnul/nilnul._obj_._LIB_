using System;

namespace nilnul.obj.op._call_
{

	public interface OpI<TOp>
		//where TOp:nilnul.obj._op_.BlankI
	{
		TOp op { get;  }
	}
}