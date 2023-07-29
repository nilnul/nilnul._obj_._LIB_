namespace nilnul.obj.abgebra_.cobiop_.semi4both_.semiring_
{
	/// ncatlab.org/nlab/show/near-ring
	///
	/// remove commutativeness from <see cref="cobiop_.semi_.demi_.grp4add_.IRing"/> is impossible, as <see cref="demi_.grp4add_.monoid4mul_.xpn_.INoncommutative"/>;
	///but we can change distributiveness to semidistributive in the mean time;
	/// 
	/// 
	/// for mul,
	///		it's <see cref="abgebra_.pargoid_.magma_.ISemigrp"/>;
	/// <summary>
	/// for add,
	///		it's <see cref="abgebra_.pargoid_.magma_.semigrp_.monoid_.IGrp"/>; (not necessarily abelian)
	/// </summary>
	/// <remarks>
	/// Near-rings arise naturally from functions on groups.
	/// </remarks>
	/// 
	/// 
	/// 
	/// alias:
	///		nearring
	///		neaRing
	///		neaR, where "n" means negation;
	///		
	public interface INearRing
		:ISemiring
		,
		_near.IGroup4add
	{ }
}
