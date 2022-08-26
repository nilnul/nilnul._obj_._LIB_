using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{


	/// <summary>
	/// if you don't need the implement of hashcode, use <see cref="obj.re_.IEquiv"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public  interface EqI<T>: IEqualityComparer<T>,IEq
	{

	}


}
