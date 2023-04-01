namespace nilnul.obj
{
	/// each component is of the same type:<typeparamref name="T"/>
	/// <summary>
	/// two items of the same type, but might be of different subtype.
	/// </summary>
	/// vs:
	///		<see cref="obj.IDuo"/>
	public interface ICo:obj.vec_.ICo
		,
		IDuo /// co shall be shorter, that's why we create a new type for;
	{

	}

	
}
