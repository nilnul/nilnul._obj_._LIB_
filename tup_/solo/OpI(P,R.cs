using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.mono
{

	public interface OpI<T>
		:OpI<T,T>
	{

	}

	public interface OpI<in P,out R>
		:_op.EvalI<P,R>, obj.OpI
	{

	}
	public interface OpI_RHead<out R, in P>
		:_op.EvalI<P,R>
		,obj.OpI
	{

	}


}
