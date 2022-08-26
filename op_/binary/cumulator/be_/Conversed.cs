using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_
{


	/// <summary>
	/// used to judge another cumulator which is the converse of the original.
	/// </summary>
	public class ByConversing<T,TBe>
		:
		nilnul.obj.Box1<TBe>
		,

		binary.cumulator.Be_cumulatorGeneriI<T>
		where TBe: cumulator.Be_cumulatorGeneriI<T>

	{
		public ByConversing(TBe val) : base(val)
		{
		}

		public bool be(CumulatorI<T> obj)
		{
			return boxed.be(
				cumulator.op0_.unary_.Converse<T>.Singleton.op(obj)
			);
			//throw new NotImplementedException();
		}

	}
	public class ByConversing<T>
		:

		nilnul.obj.Box1<cumulator.Be_opGeneriI<T>>
		,

		binary.cumulator.Be_cumulatorGeneriI<T>

	{
		public ByConversing(Be_opGeneriI<T> val) : base(val)
		{
		}

		public bool be(CumulatorI<T> obj)
		{
			return boxed.be(
				cumulator.op0_.unary_.Converse<T>.Singleton.op(obj)
			);
			//throw new NotImplementedException();
		}

	}
}
