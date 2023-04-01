namespace nilnul.obj_
{
	/// <summary>
	/// xpn is regarded as the subtype of the returned type from a function, so xpn shall be placed under returnedType_.xpn_.SomeXpn.
	/// when you expect some Type, "TReturn", from a func, the expected exception is the subtype of "tReturn_.Xpn"
	///		the func can be complex enough such that various exception is thrown. So any exception can be the subtype of "TReturn", or more specifically, "tReturn_.Xpn"。
	///			Nevertheless, defining "tReturn_.xpn_.SomeXpn" (and inherting the marker interface of "tReturn_.IXpn") would make the exception's meaning more explicity to caller.
	///		but still, given a function, we know the complexity of that function, and hence we know the exception -- we just cannot predefine the thrown exception as the sbutype of the returned type statically.
	/// </summary>
	/// <remarks>
	/// for nilnul.obj_.Vowee, the complement is nilnul.obj_.Xpn
	/// </remarks>
	public interface IXpn { }
}
