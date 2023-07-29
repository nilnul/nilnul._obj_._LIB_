namespace nilnul.obj_
{

	/// image on an envelop cover, a form with blanked space is used to fill in an address.
	/// If the form is filled with a wrong address, it's an exception.
	/// If the form is blanked, it's a null reference.
	///
	/// in C#, Null Refeence exception can happen, but wrong address exception cannot happen due to compiler check.
	///
	/// <summary>
	/// interpret the obj as a reference.
	/// the obj can be nul, resulting a null reference.
	/// the obj can be value type, and it may be unable to be casted as a reference.
	/// </summary>
	/// <remarks>
	/// only reference type is intended as this.
	/// </remarks>
	/// alias:
	///		ref0nul
	///			which is like <see cref="nilnul.objs_.EmptyI"/> that can mean an empty collection, meaning a collection of at most one, which can be empty.
	/// vs:
	///		ILiteral|Val
	///
	///		
	public interface IRef0nul
		//:IObj
		/// nul is not obj.
	{ }


}
