using System.Collections.Generic;

namespace nilnul.obj.str.to_
{
	public interface ScalarI<T>
		:nilnul.obj.str.ToI<T,T>

	{

	}

	public abstract class ScalarA<T>
		: ScalarI<T>
		,
		_scalar_.OfParamsI<T>
	{
		public abstract T to(IEnumerable<T> par);

		public T op(params T[] objs)
		{
			return to((IEnumerable<T>)objs);
			//throw new System.NotImplementedException();
		}
	}
}
