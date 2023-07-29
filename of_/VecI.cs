using nilnul.obj.of_.vec_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_
{
	/// <summary>
	/// vs:str, the arity is known in advance;
	/// </summary>
	public interface IVec :IOf,IStr{ }

	/// <summary>
	/// the inputs is vec. the output type might be different from the type of the component of the vec
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IVec<out T>
		:IOf1<T>,IVec
	{

	}

	public interface IVec<out T, TComponent>
		:IVec<T>
	{

	}




	/// <summary>
	/// of a vector. This is a n-ary operator, but we dont know the arity statically.
	/// </summary>
	///
	[Obsolete(nameof(ScalaI<T>))]
	public interface VecI<T>
		:of_.IVec
		,
		_vec_.ArityI
		,
        vec_._scala_.OpI<T>
	{

	}



}
