using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{

	


	[Obsolete()]
	public interface StartedI1<T, TTail> 
		: 
		StartedI
		,
		_started_.HeadI<T>
		, 
		_started_.TailI<TTail>

		where TTail: nilnul.ObjsI2<T>
	{
	}






}
