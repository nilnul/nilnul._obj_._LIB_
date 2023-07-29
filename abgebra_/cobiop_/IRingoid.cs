namespace nilnul.obj.abgebra_.cobiop_
{
	/// <summary>
	/// <seealso cref="ISemiring"/>
	/// 
	/// </summary>
	/// <remarks>
	///Ringoids and lattices can be clearly distinguished despite both having two defining binary operations. In the case of ringoids, the two operations are linked by the distributive law; in the case of lattices, they are linked by the absorption law. Ringoids also tend to have numerical models, while lattices tend to have set-theoretic models.
	/// </remarks>
	/// (en.wikipedia.org/wiki/Outline_of_algebraic_structures#Types_of_algebraic_structures)
	///
	/// alias:
	///		ringlike
	///		ringish
	///		ringy
	///		ringoid, where "oid" means "void"; not yet ring.
	public interface IRingoid
		:
		 semi4both_.ISemiDistributive
		//,
		//ICobiop
	{ }


}
