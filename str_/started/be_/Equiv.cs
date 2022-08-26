using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started.be_
{
	static public class _AllEqX
	{
		static public bool Be<T>(
			T seed,

			IEnumerable<T> str
			,
			IEqualityComparer<T> eq
		) {

			return str.All(x=> eq.Equals(x,seed));
		}
		static public bool Be_ofStarted<T>(
			IEnumerable<T> started
			,
			IEqualityComparer<T> eq
		) {

			return Be(started.First(),started.Skip(1) ,eq);

		}

		static public bool Be_ofStarted<T>(
			IEnumerable<T> started
			
		) {

			return Be_ofStarted(started, EqualityComparer<T>.Default);

		}

	}
}
