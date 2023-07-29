using System;

namespace nilnul.obj_.xpn_
{
	/// <summary>
	/// there is no such object;
	/// </summary>
	public interface INonexist:IXpn
	{
	}

	/// <summary>
	/// not exist;
	/// </summary>
	/// <remarks>
	/// sometimes it's equivalent to be not visible to a user without proper access;
	/// for access exception, see nilnul.acc;
	/// </remarks>

	[Serializable]
	public class NonexistException : Exception
	,
	INonexist
	{

		public NonexistException() { }
		public NonexistException(string message) : base(message) { }
		public NonexistException(string message, Exception inner) : base(message, inner) { }
		protected NonexistException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		static public NonexistException OfObjName(string objName)
		{

			return new NonexistException(
				string.Format( _nonexist.RscX.Msg, objName )
			);
		}
	}

}
