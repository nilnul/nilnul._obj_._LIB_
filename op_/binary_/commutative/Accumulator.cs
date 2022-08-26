using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutative
{
	public interface CumulatorI<T, TOp>
		:
		obj.op_.binary.AccumulatorI<T,TOp>
		  where TOp: nilnul.obj.op_.binary_.CommutableI<T>
	{
	}
	public interface CumulatorI<T>
		 : CumulatorI<T, nilnul.obj.op_.binary_.CommutableI<T>>

	{
	}

	public interface CumulatorI< T,  TOp,TOpCommutative, TVow>
		: binary.AccumulatorI<T, TOp>
		where TOp:nilnul.obj.op_.BinaryI<T>
		where TVow: nilnul.obj.op_.binary.be_.commutative.Vow_beGeneral<T,TOp>,new()
		where TOpCommutative : nilnul.obj.op_.binary_.Commutative<T,TOp,TVow>
	{
	}

	static public class CumulatorX
	{
		static public T Cumulate<T, TOp>(this CumulatorI<T, TOp> accumulator, nilnul.obj.str_.SeqI1<T> seq)
			where TOp : nilnul.obj.op_.binary_.CommutableI<T>
		{
			return nilnul.obj.str_.seq._FoldX.Fold(seq, accumulator.initial, accumulator.binder);
		}
	}

	public class Cumulator<T, TOp>
		:
		CumulatorI<T, TOp>
		where TOp : nilnul.obj.op_.binary_.CommutableI<T>
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
		public T cumulate(nilnul.obj.str_.SeqI1<T> seq)
		{
			return CumulatorX.Cumulate(this, seq);
		}
	}

	public class Cumulator_opGeneric<T>
		:
		Cumulator<T, nilnul.obj.op_.binary_.CommutableI<T>>
		, CumulatorI<T>
	{

		public Cumulator_opGeneric(T initial, nilnul.obj.op_.binary_.CommutableI<T> accumulator) : base(initial, accumulator)
		{
		}

	}

	public class Cumulator_opDefault<T, TOp>
		:
		Cumulator<T, TOp>
		where TOp : nilnul.obj.op_.binary_.CommutableI<T>, new()
	{

		public Cumulator_opDefault(T initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{

		}

	}
	public class Cumulator_opGenericDefault<T, TOp>
		: Cumulator_opGeneric<T>

		where TOp : nilnul.obj.op_.binary_.CommutableI<T>, new()
	{
		public Cumulator_opGenericDefault(T initial) : base(initial, nilnul.obj_.Singleton<TOp>.Instance)
		{
		}
	}

	public class Cumulator_opDefault_elDefault<T, TOp>
		:
		Cumulator_opDefault<T, TOp>
		where TOp : nilnul.obj.op_.binary_.CommutableI<T>, new()
		where T : new()
	{
		public Cumulator_opDefault_elDefault() : base(nilnul.obj_.Singleton<T>.Instance)
		{
		}
	}
}
