using nilnul.obj.op_;

namespace nilnul.obj.stream
{
	/// <summary>
	/// the intial is the stream's initial; then merge next() as next;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface SubsumeI<T>
		:nilnul.obj.StreamI2<T>
		//,
		//_subsume_.LastSubsumedI<T>
	{
		
	}
}