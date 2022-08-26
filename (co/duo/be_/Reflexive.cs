using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.duo.be_
{
	public class Reflexive
		
	{
		static public bool Be<T>(
			nilnul.obj.Duo<T> pair
			,
			IEqualityComparer<T> eq
		) {
			return eq.Equals(pair.Item1, pair.Item2);
		}

		static public bool Be<T>(
			Tuple<T,T> pair
			,
			IEqualityComparer<T> eq
		) {
			return eq.Equals(pair.Item1, pair.Item2);
		}


		static public bool Not<T>(
			nilnul.obj.Duo<T> pair
			,
			IEqualityComparer<T> eq)
		{

			return !Be(pair, eq);
		}

		static public bool Not<T>(Tuple<T,T> duo
			,
			IEqualityComparer<T> eq
			
		) {
			return !Be(duo, eq);

		}

	}
}
