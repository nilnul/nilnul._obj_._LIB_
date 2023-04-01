using System;

namespace nilnul.obj
{
	/// <summary>
	/// the second type is not defined.
	/// according to nilnul rule for marker interfaces, generice ones shall inherit from less generice ones. Hence we have ICo{T,T1} herits ICo{T}.
	/// for same typed typPars, <see cref="co_.IDuo{T}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ICo<T> : ICo , IDuo<T,T>{ }




	/// <summary>
	/// the shared supType of <typeparamref name="TKey"/> and <typeparamref name="TVal"/> is not specified here;
	/// </summary>
	/// <typeparam name="TKey"></typeparam>
	/// <typeparam name="TVal">not nullable. if nullable, see nilnul._rel.Co</typeparam>
	/// <remarks>
	/// <typeparamref name="TKey"/> and <typeparamref name="TVal"/> are subtype of "nilnul.obj". when under type, <var>T</var>, other than "nilnul.obj", the "Co" there can contain generic type parameter that is the subtype of <var>T</var>
	/// </remarks>
	///
	[Obsolete(nameof(IDuo<TKey,TVal>) + " is preferred, and this shall be :" + nameof(co_.IDuo<TKey>))]
	public interface ICo<TKey, TVal>	//here T
			
		:
		ICo
		//,
		//ICo
	{
	}

	/// <summary>
	/// implementation includes:
	///		<see cref="(T0,T1)"/>
	///		<see cref="System.Tuple<T0,T1>"/>
	///		<see cref="nilnul.obj.CoI1{T, T1}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="T0"></typeparam>
	/// <typeparam name="T1"></typeparam>
	public interface ICo<T, T0, T1> : ICo<T> //, IDuo<T0,T1>
		where T0 : T
		where T1 : T
	{ }
}
