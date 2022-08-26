namespace nilnul.obj
{
	/// <summary>
	/// two items of the same type, but might be of different subtype.
	/// </summary>
	public interface ICo {

	}

	/// <summary>
	/// the second type is not defined.
	/// according to nilnul rule for marker interfaces, generice ones shall inherit from less generice ones. Hence we have ICo{T,T1} herits ICo{T}.
	/// for same typed typPars, <see cref="co_.IDuo{T}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ICo<T>:ICo { }
}
