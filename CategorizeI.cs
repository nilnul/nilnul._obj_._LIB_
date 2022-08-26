using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface _CategorizeI
	{
	}
	public interface _CategorizeI<T>:_CategorizeI {

	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TCategory">an enum predefined</typeparam>
	public interface CategorizeI<T, TCategory>
		:_CategorizeI<T>
		where TCategory:struct 
	{
		TCategory categorize(T obj);
	}
}
