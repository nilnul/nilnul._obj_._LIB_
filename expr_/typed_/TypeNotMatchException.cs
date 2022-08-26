namespace nilnul.obj._expr._exceptions
{
	[System.Serializable]
	public class TypeNotMatchException : System.Exception
	{
		public TypeNotMatchException() { }
		public TypeNotMatchException(string message) : base(message) { }
		public TypeNotMatchException(string message, System.Exception inner) : base(message, inner) { }
		protected TypeNotMatchException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{ }
	}

}

