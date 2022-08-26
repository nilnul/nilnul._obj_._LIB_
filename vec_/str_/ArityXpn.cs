using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec_.str_
{

	[Serializable]
	public class ArityException<T> : Exception
	{
		public ArityException() { }

		public ArityException(int arity, IEnumerable<T> x)
			:base(
				 $"{nameof(x)}:{x}'arity is not {arity}."
			)
		{ }

		public ArityException(string message) : base(message) { }
		public ArityException(string message, Exception inner) : base(message, inner) { }
		protected ArityException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

	[Serializable]
	public class ArityException : Exception
	{
		public ArityException() { }

		public ArityException(int arity, IEnumerable x)
			:base(
				 $"{nameof(x)}:{x}'arity is not {arity}."
			)
		{ }

		public ArityException(string message) : base(message) { }
		public ArityException(string message, Exception inner) : base(message, inner) { }
		protected ArityException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

}
