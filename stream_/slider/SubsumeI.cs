using nilnul.obj.op_;

namespace nilnul.obj.stream_.slider
{
	public interface SubsumeI<T>
		:nilnul.obj.stream_.SliderI<T>
		,
		_subsume_.LastSubsumedI<T>
	{
		
	}
}