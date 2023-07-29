namespace nilnul.obj.abgebra_.cobiop_.grp4add_.monoid4mul_
{
	/// <summary>
	///	for multi
	///		it's not only a semigrp, but also a monoid
	///			,0 can also take the role of neutral, or 1, with respect to *.
	///				,<see cref="ring_.NilOnly"/>
	/// such as integer.
	/// </summary>
	/// <remarks>
	///ring multiplication is not required to be commutative; eg: matrix with add, and multi;
	///
	/// 
	/// </remarks>
	public interface IRing
		:
		IGrp4add
		,
		_ring.IDitributive
	{
	}


}
