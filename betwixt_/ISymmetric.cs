namespace nilnul.obj.betwixt_
{
	/// <summary>
	/// both borders are of the same openCloseNess.
	/// including:
	///		<see cref="IOpen"/>
	///		<see cref="IClosed"/>
	///	excluding:
	///		<see cref="IOpenClose"/>
	///		<see cref="IClopen"/>
	/// </summary>
	/// <remarks>
	/// used for <see cref="symmetric_.ITight"/>
	/// </remarks>
	public interface ISymmetric:IBetwixt { }
}
