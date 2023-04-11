using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{


	public interface IStarted<T,TTail> : IStarted<T> { }


	public interface StartedI1<T, TTail> 
		: 
		_started_.HeadI<T>
		, 
		_started_.TailI<TTail>
		,
		IStarted<T,TTail>
		,
		nilnul.obj.str_.SeqI3<T>

		where TTail: nilnul.obj.str_.SeqI3<T>
	{
	}

	public interface StartedI1<T>
		:StartedI1<
			T
			,
			nilnul.obj.str_.SeqI3<T>
		>
	{

	}

	public interface StartedI1 : StartedI1<object> {

	}






}
