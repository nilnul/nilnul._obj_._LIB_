namespace nilnul.obj.of_.vec_
{
	/// <summary>
	/// of a vector. This is a n-ary operator, but we dont know the arity statically.
	/// </summary>
	public interface ScalaI<T>
		:of_.vec_.IScala
		,
		_vec_.ArityI
		,
		_scala_.OpI<T>
	{

	}



}
