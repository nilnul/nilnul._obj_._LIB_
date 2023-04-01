namespace nilnul.obj
{
	/// <summary>
	/// wrap a type, and expose it as another typ;
	/// </summary>
	/// alias:
	///		capsule
	///		box
	///			which is used in geometry;
	///		bottle
	///		proxy
	///		adapter
	public interface ICapsule { }

	public interface ICapsule<T>:ICapsule { }

	public interface CapsuleI<T> {

		/// <summary>
		/// </summary>
		/// alias:
		///		box
		///			for compatibility
		///		ed
		///			,which is occupied by op-ed
		/// 
		T boxed { get; }
	}


}
