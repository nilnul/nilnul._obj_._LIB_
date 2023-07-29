namespace nilnul.obj.of_.binary
{
	public interface CascaderI<out T, out TOp>
		:
		_cumulator_.BinderI<TOp>
		where TOp : nilnul.obj.of_.BinaryI<T>
	{
	}



}
