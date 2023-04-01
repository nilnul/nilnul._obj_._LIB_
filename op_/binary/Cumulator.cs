using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary
{
	public interface ICumulator<out T>
		:ICumulator

	{

	}

	/// <summary>
	/// an initial, a binary_.Op.
	/// Then this can be applied to str to get a single val of type <typeparamref name="T"/>.
	/// Or this can be applied to stream to get another stream.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOp"> </typeparam>
	public interface CumulatorI<out T, out TOp>
		:_cumulator_.InitialI<T>
		,
		_cumulator_.BinderI<TOp>
		,
		ICumulator<T>

		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		//T initial { get; }
		//TOp binder { get; }
	}
	public interface CumulatorI<T>
		 : CumulatorI<T, nilnul.obj.op_.BinaryI<T>>
	{
	}
	public abstract class _CumulatorA<T, TOp>
		
	{
		private T _initial;
		public T initial { get { return _initial; } }

		private TOp _binder;
		public TOp binder { get { return _binder; } }
		public _CumulatorA(T initial, TOp binder)
		{
			_initial = initial;
			_binder = binder;
		}
	


	}


	public class Cumulator<T, TOp>
		:
		CumulatorI<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		private T _initial;
		public T initial { get { return _initial; } }
		private TOp _binder;
		public TOp binder { get { return _binder; } }
		public Cumulator(T initial, TOp binder)
		{
			_initial = initial;
			_binder = binder;
		}
		[Obsolete(nameof(cumulator._cumulate_.OfSeq<T>))]
		public T cumulate(nilnul.obj.str_.SeqI1<T> seq)
		{
			return CumulatorX.Cumulate(this, seq);
		}
	

		[Obsolete(nameof(cumulator._cumulate_.OfSeq<T>))]
		public T cumulate(nilnul.obj.str_.SeqI2<T> seq)
		{
			return CumulatorX.Cumulate(this, seq);
		}

		[Obsolete(nameof(cumulator._cumulate_.OfSeq<T>))]
		public T cumulate(IEnumerable<T> seq)
		{
			return CumulatorX.Cumulate(this, seq);
		}

		[Obsolete(nameof(cumulator._cumulate_.OfSeq<T>))]
		public T cumulate(params T[] seq)
		{
			return CumulatorX.Cumulate(this, seq);
		}


	}

	public class Cumulator<T>
		:
		Cumulator<T, nilnul.obj.op_.BinaryI<T>>
		,
		CumulatorI<T>
	{

		public Cumulator(T initial, nilnul.obj.op_.BinaryI<T> accumulator) : base(initial, accumulator)
		{

		}

	}

	static public class CumulatorX
	{
		static public T Cumulate<T, TOp>(this CumulatorI<T, TOp> accumulator, IEnumerable<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return nilnul.obj.str_.seq._FoldX.Fold_useDefaultIfEmpty(seq, accumulator.initial, accumulator.binder);
		}

		static public T Cumulate<T, TOp>(this CumulatorI<T, TOp> accumulator, nilnul.obj.str_.SeqI2<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return nilnul.obj.str_.seq._FoldX.Fold_useDefaultIfEmpty(seq, accumulator.initial, accumulator.binder);
		}

		static public T Cumulate<T, TOp>(this CumulatorI<T, TOp> accumulator, nilnul.obj.str_.SeqI1<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return nilnul.obj.str_.seq._FoldX.Fold(seq, accumulator.initial, accumulator.binder);
		}
	}


}
