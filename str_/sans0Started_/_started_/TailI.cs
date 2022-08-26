using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sans0Started_._started_
{

	public interface TailI<out T,out TTail>
		where TTail: StrI2<T>,Sans0StartedI<T>
	{
		/// <summary>
		/// deheaded; tail
		/// </summary>
		TTail body{ get; }
	}
}
