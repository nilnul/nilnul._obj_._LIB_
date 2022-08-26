using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.eq
{
	public partial class AsProp<T,TEq>
		:AsPropI<T>
		where TEq:IEqualityComparer<T>,new()
	{
		IEqualityComparer<T> AsPropI<T>.eq
		{
			get {

				return SingletonByDefault<TEq>.Instance;
				
				throw new NotImplementedException(); 
			
			}
		}
	}
}
