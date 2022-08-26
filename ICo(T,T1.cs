namespace nilnul.obj
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TKey"></typeparam>
	/// <typeparam name="TVal">not nullable. if nullable, see nilnul._rel.Co</typeparam>
	/// <remarks>
	/// <typeparamref name="TKey"/> and <typeparamref name="TVal"/> are subtype of "nilnul.obj". when under type, <var>T</var>, other than "nilnul.obj", the "Co" there can contain generic type parameter that is the subtype of <var>T</var>
	/// </remarks>
	public interface ICo<TKey, TVal>	//here T
			
		:
		ICo<TKey>
		//,
		//ICo
	{
	}
}
