using System;

namespace nilnul.obj_
{
	/// <summary>
	/// xpn is regarded as the subtype of the returned type from a function, so xpn shall be placed under returnedType_.xpn_.SomeXpn.
	/// when you expect some Type, "TReturn", from a func, the expected exception is the subtype of "tReturn_.Xpn"
	///		the func can be complex enough such that various exception is thrown. So any exception can be the subtype of "TReturn", or more specifically, "tReturn_.Xpn"¡£
	///			Nevertheless, defining "tReturn_.xpn_.SomeXpn" (and inherting the marker interface of "tReturn_.IXpn") would make the exception's meaning more explicity to caller.
	///		but still, given a function, we know the complexity of that function, and hence we know the exception -- we just cannot predefine the thrown exception as the sbutype of the returned type statically.
	/// </summary>
	/// <remarks>
	/// for nilnul.obj_.Vowee, the complement is nilnul.obj_.Xpn
	/// </remarks>
	public interface IXpn { }
	/// <summary>
	/// for anything that is incompatible with an instance of T
	///  an xpn that is the subtype of T.
	///  t_.IXpn will inherit from this one.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IXpn<T> { }
	/// <summary>
	/// the bottom type, which is the subtype of all types. no instace is of this type
	/// </summary>
	public interface XpnI:IXpn
	{
		void throws();
	}
	[System.Serializable]
	public abstract class XpnAbstractException : Exception, XpnI
	{
		public XpnAbstractException() { }
		public XpnAbstractException(string message) : base(message) { }
		public XpnAbstractException(string message, Exception inner) : base(message, inner) { }
		protected XpnAbstractException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		public void throws()
		{
			throw this;
		}
	}

	public static class XpnX
	{
		public static void Throw<T>(this T xpn)
			where T : Exception
		{
			throw xpn;
		}
	}
	public class Xpn<T>
		: nilnul.obj.Box1<T>
		,
		XpnI
		where T : Exception
	{
		public Xpn(T val) : base(val)
		{
		}

		public void throws()
		{
			throw boxed;
		}
	}
}
