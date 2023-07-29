namespace nilnul.obj.stream_.slider
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// alias:
	///		scoped
	///		buffered
	///		windowed
	/// </remarks>
	public interface BufferedI<T>
		:nilnul.obj.stream_._slider._cursor_.CurrentI<T>

	{
		nilnul.obj.Buffer<T> buffer
		{
			get;
		}
		void move();

	}


}
