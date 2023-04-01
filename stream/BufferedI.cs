namespace nilnul.obj.stream
{
	/// <summary>
	/// a cyclic buffer of a fixed size;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface BufferedI<T>
	{
		nilnul.obj.Buffer<T> buffer
		{
			get;
		}
		void move();
	}


}
