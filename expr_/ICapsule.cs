namespace nilnul.obj.expr_
{
	/// <summary>
	/// every var is of the result type.
	/// </summary>
	/// alias:
	///		capsul
	///		capsule
	///		capsel
	///		capsol
	///		capsil
	///		capsal
	public interface ICapsule:IExpr { }

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">
	/// type of var; also type of ret;
	/// </typeparam>
	public interface ICapsule<T>:IExpr<T>,ICapsule { }


}
