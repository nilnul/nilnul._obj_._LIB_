using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.op_.binary;
using nilnul.obj.seq;

namespace nilnul.obj.str_.seq
{
	static public class _FoldX
	{
		/// <summary>
		/// /// note the start of the <paramref name="str"/> has to be compared with <paramref name="initial"/>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="str"></param>
		/// <param name="initial"></param>
		/// <param name="accumulator"></param>
		/// <returns></returns>

		static public T Fold_useDefaultIfEmpty<T>(this IEnumerable<T> str, T initial, nilnul.obj.op_.BinaryI<T> accumulator)
		{
			return str.Aggregate(initial, accumulator.op);

			//return str.Prepend(initial).Aggregate(accumulator.op);

			#region wrong as the the initial is not compared with the first of the str
			//if (str.None())
			//{
			//	return initial;
			//}
			//return str.Aggregate(accumulator.op);


			#endregion
		}

		static public T Fold_useDefaultIfEmpty<T>(this nilnul.obj.str_.SeqI1<T> str, T initial, nilnul.obj.op_.BinaryI<T> accumulator)
		{

			return Fold_useDefaultIfEmpty(str.seq.ee, initial, accumulator);
			//return str.seq.ee.DefaultIfEmpty(initial).Aggregate( accumulator.op);
		}

		static public T Fold_useDefaultIfEmpty<T>(this nilnul.obj.str_.SeqI2<T> str, T initial, nilnul.obj.op_.BinaryI<T> accumulator)
		{
			return Fold_useDefaultIfEmpty<T>((IEnumerable<T>)str, initial, accumulator);
		}

		static public T Fold<T>(this nilnul.obj.str_.SeqI1<T> str, T initial, nilnul.obj.op_.BinaryI<T> accumulator)
		{
			return Fold_useDefaultIfEmpty(str.seq.ee, initial, accumulator);
				//str.seq.ee.Aggregate(initial, accumulator.op);
		}

	}
	public class Fold<T, TOp> :
		nilnul.obj.Box<
			nilnul.obj.op_.binary.AccumulatorI<T, TOp>
			>
		,
		FoldI<T>
		,
		obj.str_.seq._fold_.OvSeq<T>
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		public Fold(AccumulatorI<T, TOp> val) : base(val)
		{
		}

		public Fold(T initial, TOp accumulator) : this(new nilnul.obj.op_.binary.Accumulator<T, TOp>(initial, accumulator))
		{
		}

		public T fold(IEnumerable<T> x)
		{
			return x.Aggregate(boxed.initial, boxed.binder.op);
		}

		public T fold(SeqI1<T> x)
		{

			return fold(x.seq.ee);  //.Aggregate(boxed.initial, boxed.binder.op);
		}

	}
	public class Fold_ofAccumulator<T, TAccumulate> :
		nilnul.obj.Box<TAccumulate>
		,
		FoldI<T>
		where TAccumulate : nilnul.obj.op_.binary.AccumulatorI<T>
	{


		public Fold_ofAccumulator(TAccumulate accumulator) : base(accumulator)
		{

		}

		public T fold(SeqI1<T> x)
		{
			return _FoldX.Fold(x, boxed.initial, boxed.binder);
		}
	}

	public class Fold_accumulatorDefault<T, TAccumulate> :
		Fold_ofAccumulator<T, TAccumulate>

		where TAccumulate : nilnul.obj.op_.binary.AccumulatorI<T>, new()
	{


		public Fold_accumulatorDefault() : base(nilnul.obj_.Singleton<TAccumulate>.Instance)
		{

		}
	}



}
