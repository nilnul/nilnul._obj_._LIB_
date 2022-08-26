using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started.op_.unary_
{
	/// <summary>
	/// map each element to another element. another name for ling select.
	/// </summary>
	public interface IMap
	{
	}
	public interface MapI<TElement>
		: UnaryI<TElement>
		,
		IMap
	{

	}

	public class Map<TElement>
		:
		nilnul.obj.Box1<
			Func<TElement,TElement>
		>

		,
		MapI<TElement>
	{
		public Map(Func<TElement, TElement> val) : base(val)
		{
		}

		public StartedI2<TElement> op(StartedI2<TElement> par)
		{
			return new Started4<TElement>( par.Select(e=> boxed(e) )  );
		}
	}
}
