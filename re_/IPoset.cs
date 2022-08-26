namespace nilnul.obj.re_
{
	/// <summary>
	/// reflexive, symmetric, and transitive
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///alias:
	///		partial order
	///		order
	///		poset
	///			partial orderred set
	public interface IPoset
		:
		IPreOrd
		,
		IAntiSymmetric
	
		,
		nilnul.obj.IRe
	{

	}


}

