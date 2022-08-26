namespace nilnul.obj.re_
{
	/// <summary>
	/// reflexive, symmetric, and transitive
	/// no hashcode vs: <see cref="nilnul.obj.EqI{T}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	public interface IEquiv
		:
		IPreOrd
		,
		ISymmetric
		
		,
		nilnul.obj.IRe
	{

	}


}

