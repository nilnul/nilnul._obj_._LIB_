using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary
{
	[Obsolete(nameof(binary.converse.cumulator))]
	static public class _CumulatorRightX
	{
		/// <summary>
		/// the accumulated is put as the last/right argument.
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="list"></param>
		/// <param name="accumulator"></param>
		/// <param name="func"> diff from <see cref="IEnumerable{T}.Aggregate"/> func in that the par types there are (TAccumulated, TSource,TAccumualted). note the juxtopose of the two inputs.
		///
		/// </param>
		/// <param name="i"></param>
		/// <returns></returns>
		static TResult CumulateRight<TSource, TResult>(IEnumerator<TSource> list, TResult accumulated, Func<TSource, TResult, TResult> func)
		{
			while (list.MoveNext())
			{
				accumulated = func(list.Current,accumulated);
			}

			return accumulated;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="list"></param>
		/// <param name="accumulator"></param>
		/// <param name="func"> diff from <see cref="IEnumerable{T}.Aggregate"/> func in that the par types there are (TAccumulated, TSource,TAccumualted). note the juxtopose of the two inputs.</param>
		/// <param name="i"></param>
		/// <returns></returns>
		static TResult CumulateRight<TSource, TResult>(IEnumerable<TSource> list, TResult initial, Func<TSource, TResult, TResult> func)
		{
			return CumulateRight(list.GetEnumerator(),initial,func);
		}

		static public T CumulateRight<T, TOp>(this CumulatorRightI<T, TOp> accumulator, IEnumerable<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return CumulateRight( seq, accumulator.initial,accumulator.binder.op);
		}

		static public T CumulateRight<T, TOp>(this CumulatorRightI<T, TOp> accumulator, nilnul.obj.str_.SeqI2<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return CumulateRight(seq, accumulator.initial, accumulator.binder.op);
		}

		static public T CumulateRight<T, TOp>(this CumulatorRightI<T, TOp> accumulator, nilnul.obj.str_.SeqI1<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return CumulateRight(seq.seq.ee, accumulator.initial, accumulator.binder.op);
		}
	}

	[Obsolete(nameof(binary.converse.cumulator))]

	public interface ICumulatorRight { }
	[Obsolete(nameof(binary.converse.cumulator))]

	public interface ICumulatorRight<out T>
		:ICumulatorRight

	{

	}

	/// <summary>
	/// an initial, a binary_.Op.
	/// Then this can be applied to str to get a single val of type <typeparamref name="T"/>.
	/// Or this can be applied to stream to get another stream.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOp"> </typeparam>
	///
	[Obsolete(nameof(binary.converse.cumulator))]

	public interface CumulatorRightI<out T, out TOp>
		:_cumulator_.InitialI<T>
		,
		_cumulator_.BinderI<TOp>
		,
		ICumulatorRight<T>

		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		//T initial { get; }
		//TOp binder { get; }
	}

	[Obsolete(nameof(binary.converse.cumulator))]

	public interface CumulatorRightI<T>
		 : CumulatorRightI<T, nilnul.obj.op_.BinaryI<T>>
	{
	}

	[Obsolete(nameof(binary.converse.cumulator))]

	public abstract class _CumulatorRightA<T, TOp>
		
	{
		private T _initial;
		public T initial { get { return _initial; } }

		private TOp _binder;
		public TOp binder { get { return _binder; } }
		public _CumulatorRightA(T initial, TOp binder)
		{
			_initial = initial;
			_binder = binder;
		}

	}

	[Obsolete(nameof(binary.converse.cumulator))]

	public class CumulatorRight<T, TOp>
		:
		CumulatorRightI<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		private T _initial;
		public T initial { get { return _initial; } }
		private TOp _binder;
		public TOp binder { get { return _binder; } }
		public CumulatorRight(T initial, TOp binder)
		{
			_initial = initial;
			_binder = binder;
		}
		[Obsolete(nameof(cumulator._cumulate_.OfSeq<T>))]
		public T cumulate(nilnul.obj.str_.SeqI1<T> seq)
		{
			return _CumulatorRightX.CumulateRight(this, seq);
		}


		[Obsolete(nameof(cumulator._cumulate_.OfSeq<T>))]
		public T cumulate(nilnul.obj.str_.SeqI2<T> seq)
		{
			return _CumulatorRightX.CumulateRight(this, seq);
		}

		[Obsolete(nameof(cumulator._cumulate_.OfSeq<T>))]
		public T cumulate(IEnumerable<T> seq)
		{
			return _CumulatorRightX.CumulateRight(this, seq);
		}

		[Obsolete(nameof(cumulator._cumulate_.OfSeq<T>))]
		public T cumulate(params T[] seq)
		{
			return _CumulatorRightX.CumulateRight(this, seq);
		}


	}
	[Obsolete(nameof(binary.converse.cumulator))]

	public class CumulatorRight<T>
		:
		CumulatorRight<T, nilnul.obj.op_.BinaryI<T>>
		,
		CumulatorRightI<T>
	{

		public CumulatorRight(T initial, nilnul.obj.op_.BinaryI<T> accumulator) : base(initial, accumulator)
		{

		}

	}



}
