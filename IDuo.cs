namespace nilnul.obj
{
	/// <summary>
	/// vs <see cref="obj.vec_.ICo"/>, this can have two different types.
	/// </summary>
	/// implementation includes:
	///		<see cref="(T0,T1)"/>
	///		<see cref="System.Tuple<T0,T1>"/>
	///		<see cref="nilnul.obj.CoI1{T, T1}"/>
	///	alias:
	///		duo
	///			three letters,same as map;
	///		mapTo
	///		to
	///		co
	///			co is shorter and shall need less info; duo is longer, and need more info, which the type of the val, the last parameter;

	public interface IDuo:obj.ITup,obj.tup_.IDuo { }
}
