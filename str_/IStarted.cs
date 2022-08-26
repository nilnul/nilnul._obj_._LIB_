using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{

	public interface IStarted:nilnul.IObjs {

	}

	public interface IStarted<T> : IStarted { }

	public interface IStarted<T, TTail>
		:IStarted<T>
		where TTail: nilnul.ObjsI3<T>
	 {
	}






}
