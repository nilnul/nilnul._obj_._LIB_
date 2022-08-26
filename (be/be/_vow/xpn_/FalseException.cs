using System;

namespace nilnul.obj.be._vow.xpn_
{
	[Serializable]
	public class FalseException<T, TBe> : Exception, nilnul.obj_.XpnI
		where TBe : nilnul.obj.BeI1<T>
	{
		private TBe _be;

		public TBe be
		{
			get { return _be; }
			set { _be = value; }
		}

		private T _obj;

		public T obj
		{
			get { return _obj; }
			set { _obj = value; }
		}


		public FalseException(TBe be, T obj)
		{
			_be = be;
			_obj = obj;
		}

		[Obsolete()]
		public FalseException(string message) : base(message) { }
		[Obsolete()]
		public FalseException(string message, Exception inner) : base(message, inner) { }

		[Obsolete()]

		protected FalseException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

		public void throws()
		{
			throw this;
			//throw new NotImplementedException();
		}

		public override string Message => $"{_be}({_obj}) is false.";

		//public override string ToString()
		//{
		//	return $"{_be}({_obj}) is false.";
		//}
	}

}
