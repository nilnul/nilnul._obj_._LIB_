using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{


	/// <summary>
	/// sometimes, we cannot know for sure whether the two is eq.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface EqNulableI<T>
	{
		bool? eq(T a, T b);
	}


}
