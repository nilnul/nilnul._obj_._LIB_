using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public  class EqX
	{
		static public bool Eq<T>(T a,T b, Func<T,T,bool> EqNoNull) {
			if (object.ReferenceEquals( a,null) )
			{
				if (object.ReferenceEquals(b,null))
				{
					return true;
					
				}
				return false;
				
			}
			return EqNoNull(a, b);

		
		}

		static public bool Ne<T>(IEqualityComparer<T> eq, T x, T y) {
			return !eq.Equals(x, y);
		}


	}
}
