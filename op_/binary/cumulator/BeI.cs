using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator
{
	public interface BeI<T,TOp,TCumulator>
		:
		nilnul.obj.BeI1<TCumulator>
		where TCumulator: binary.CumulatorI<T,TOp>
		where TOp: obj.op_.BinaryI<T>
	{
	}
	public interface BeI<T,TOp>
		:
		BeI<T,TOp,binary.CumulatorI<T,TOp>>

		where TOp: obj.op_.BinaryI<T>
	{
	}

	public interface Be_ovObj_ovCumulatorI<T,TCumulator>
		:
		BeI<T,obj.op_.BinaryI<T>, TCumulator>

		where TCumulator: obj.op_.binary.CumulatorI<T>
	{
	}



	public interface Be_opGeneriI<T>
		:
		BeI<T, obj.op_.BinaryI<T>>
	{
	}

	public interface Be_cumulatorGeneriI<T>
		:
		Be_ovObj_ovCumulatorI<T, CumulatorI<T>>
	{
	}





}
