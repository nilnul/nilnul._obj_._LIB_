using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary
{
	[Obsolete()]
	public interface AccumulatorI<out T, out TOp>
		:_cumulator_.InitialI<T>
		,
		_cumulator_.BinderI<TOp>

		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		//T initial { get; }
		//TOp binder { get; }
	}

	[Obsolete()]
	public interface AccumulatorI<T>
		 : AccumulatorI<T, nilnul.obj.op_.BinaryI<T>>
	{
	}

	[Obsolete()]
	static public class AccumulatorX
	{
		static public T Accumulate<T, TOp>(this AccumulatorI<T, TOp> accumulator, IEnumerable<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return nilnul.obj.str_.seq._FoldX.Fold_useDefaultIfEmpty(seq, accumulator.initial, accumulator.binder);
		}

		static public T Accumulate<T, TOp>(this AccumulatorI<T, TOp> accumulator, nilnul.obj.str_.SeqI2<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return nilnul.obj.str_.seq._FoldX.Fold_useDefaultIfEmpty(seq, accumulator.initial, accumulator.binder);
		}

		static public T Accumulate<T, TOp>(this AccumulatorI<T, TOp> accumulator, nilnul.obj.str_.SeqI1<T> seq)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return nilnul.obj.str_.seq._FoldX.Fold(seq, accumulator.initial, accumulator.binder);
		}
	}

	[Obsolete()]
	public class Accumulator<T, TOp>
		:
		AccumulatorI<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		private T _initial;
		public T initial { get { return _initial; } }
		private TOp _binder;
		public TOp binder { get { return _binder; } }
		public Accumulator(T initial, TOp binder)
		{
			_initial = initial;
			_binder = binder;
		}
		public T accumulate(nilnul.obj.str_.SeqI1<T> seq)
		{
			return AccumulatorX.Accumulate(this, seq);
		}
		public T accumulate(nilnul.obj.str_.SeqI2<T> seq)
		{
			return AccumulatorX.Accumulate(this, seq);
		}

		public T accumulate(IEnumerable<T> seq)
		{
			return AccumulatorX.Accumulate(this, seq);
		}

		public T accumulate(params T[] seq)
		{
			return AccumulatorX.Accumulate(this, seq);
		}


	}

	//public class Accumulator<T, TOp>
	//	:
	//	AccumulatorA<T, TOp>
	//	where TOp : nilnul.obj.op_.BinaryI<T>
	//{
	//	//private T _initial;

	//	//public override T initial
	//	//{
	//	//	 get { return _initial; }
	//	//	//set { _initial = value; }
	//	//}

	//	//private TOp _accumulator;

	//	//public override TOp binder
	//	//{
	//	//	get { return _accumulator; }
	//	//	//set { _accumulator = value; }
	//	//}
	//	public Accumulator(T initial, TOp accumulator):base()
	//	{
	//		_initial = initial;
	//		_accumulator = accumulator;
	//	}

	//}
	[Obsolete()]

	public class Accumulator_opGeneric<T>
		:
		Accumulator<T, nilnul.obj.op_.BinaryI<T>>
		, AccumulatorI<T>
	{

		public Accumulator_opGeneric(T initial, nilnul.obj.op_.BinaryI<T> accumulator) : base(initial, accumulator)
		{

		}

	}
	[Obsolete()]

	public class Accumulator_opDefault<T, TOp>
		:
		Accumulator<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{

		public Accumulator_opDefault(T initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{

		}

	}
	[Obsolete()]

	public class Accumulator_opGenericDefault<T, TOp>
		: Accumulator_opGeneric<T>

		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public Accumulator_opGenericDefault(T initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}

	[Obsolete()]

	public class Accumulator_opDefault_elDefault<T, TOp>
		:
		Accumulator_opDefault<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
		where T : new()
	{

		public Accumulator_opDefault_elDefault() : base(nilnul.obj_.Singleton<T>.Instance)
		{

		}

	}


}
