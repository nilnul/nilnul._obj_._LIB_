namespace nilnul.obj
{

	/// <summary>
	/// the second type is not defined.
	/// according to nilnul rule for marker interfaces, generice ones shall inherit from less generice ones. Hence we have IDuo{T,T1} herits IDuo{T}.
	/// for same typed typPars, <see cref="co_.ICo{T}"/>
	/// </summary>
	/// <remarks>
	/// a map from <typeparamref name="TKey"/> to something;
	/// </remarks>
	/// <typeparam name="TKey"></typeparam>
	public interface IDuo<TKey> : IDuo { }




	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TKey"></typeparam>
	/// <typeparam name="TVal">not nullable. if nullable, see nilnul._rel.Co</typeparam>
	/// <remarks>
	/// <typeparamref name="TKey"/> and <typeparamref name="TVal"/> are subtype of "nilnul.obj". when under type, <var>T</var>, other than "nilnul.obj", the "Co" there can contain generic type parameter that is the subtype of <var>T</var>;
	/// a map from <typeparamref name="TKey"/> to <typeparamref name="TVal"/>
	/// </remarks>
	public interface IDuo<TKey, TVal>	//here T
			
		:

		IDuo<TKey>
		,
		IDuo
	{
	}

	

}
