namespace nilnul.obj.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		nonary
	///			,
	///				vs nary,
	///					re: unary, ternary, we need a notion of at least two letters. <seealso cref="obj.vec_.Nono{T}"/>
	///		<see cref="obj.ConstantI{T}"/>
	public interface INary : IOp
	{


	}
	public interface INary<out T> : INary
		,
		obj.of_.IOfEmpty<T>


	{


	}


}
