using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._str.recur_.headed0Sans_._headed_
{

	public interface TailI<T,TTail>
		where TTail: RecurI<T>
	{
		TTail tail{ get; }
	}
}
