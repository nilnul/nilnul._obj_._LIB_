namespace nilnul.obj
{
	/// <summary>
	/// given a natural number,
	///		a str of that length.
	///	vec cannot be instantiated as the arity is unknown (but str can be instantiated without preset arity)
	///	to instantiate a vec, a subtype, such as <see cref="vec_.Co{T}"/>, must be defined first before we can instantiate it.
	///		
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// alias:
	///		vec
	///			"v" implies value in value tuple
	///		vector
	///		vect
	///	vs:
	///		Str
	///			common: the type of each component is same.
	///			diff: the length of rec is dynamic; whileas the length of vec is preset.
	///		Tup
	///			common: length preset.
	///			diff: for vec, the types of each component is same. for tup, the type of each componen vary as the subtype of a common type.
	///			So a tup can be converted to a vec of that common type.
	/// 
	/// 
	public interface IVec
		:
		IStr
		,
		ITup  // V inherits S,T, which inturn inherit R
	{
	}
	/// unlike str, which is different type only on ElType, vec is not only typed on ElTyp, but also on arity. So it's hard to predefine this type before knowing the arity.
	/// So generally, when we know the elementType, we define a general empty mark interface. for the concrete type with a certain arity, we define in a later project.
	/// Eg: for real, we define real.Vec.
	/// but only when in geometry.stereo, we define real.vec_.Tro.
	/// but for co, it's very often used, so we don't defer it to geometry.planar; rather, we define it at nilnul.num.real.
	///
	/// the above is one reason that co, tro, quod,quind,uno,nino, etc is placed not under the namspace "vec_", but directly under the domain name such as "nilnul.obj"
}
