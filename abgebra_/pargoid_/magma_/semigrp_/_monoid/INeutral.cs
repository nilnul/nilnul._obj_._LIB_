namespace nilnul.obj.abgebra_.pargoid_.magma_.semigrp_._monoid
{
	/// <summary>
	/// there exists x, for any y, x+y =y+x=y; where x is the neutral element;
	/// </summary>
	/// <remarks>
	/// for add, the neutral element is 0, the nil; for multi, the neutral element is 1, the one;
	/// </remarks>
	/// alias:
	///		neutral, like the neutral chemical, which doesnot affect others;
	///	vs:
	///		annillator, which is a x, for any y x*y=y*x = x; this is considered in <see cref="ICobiop"/>, <see cref="cobiop.mul.IAnnihilator"/>, as the annillator for multi is generally a neutral for addition;
	public interface INeutral
		:semigrp_.IDwelt
	{
	}




}
