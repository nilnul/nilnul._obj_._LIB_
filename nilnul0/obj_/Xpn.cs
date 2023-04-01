using System;

namespace nilnul.obj_
{
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
