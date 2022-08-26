using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary
{
	public interface AccumulatorI1< T, out TOp,  TEq>
		: CumulatorI<T,TOp>
		,
		_accumulator_.AnnilatorI<T>
		,
		_accumulator_.ElEqI<T,TEq>
		

		where TOp : nilnul.obj.op_.BinaryI<T>
		where TEq: IEqualityComparer<T>
	{
		//T initial { get; }
		//TOp binder { get; }
	}

	/// <summary>
	/// an initial, a binary_.Op.
	/// Then this can be applied to str to get a single val of type <typeparamref name="T"/>.
	/// Or this can be applied to stream to get another stream.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOp"> </typeparam>
	public interface AccumulatorI1< T, out TOp>
		: AccumulatorI1<T,TOp, IEqualityComparer<T>>
		,
		_accumulator_.AnnilatorI<T>
		,
		_accumulator_.ElEqI<T>
		

		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		//T initial { get; }
		//TOp binder { get; }
	}

	public interface AccumulatorI1<T>
		 : AccumulatorI1<T, nilnul.obj.op_.BinaryI<T>>
	{
	}

	public abstract class _AccumulatorA1<T, TOp,TEq>
		:_CumulatorA<T,TOp>
		
	{
		private T _annilator;
		public T annilator { get { return _annilator; } }

		private TEq _elEq;

		public TEq elEq
		{
			get { return _elEq; }
			set { _elEq = value; }
		}


		public _AccumulatorA1(T initial, TOp binder, T _annilator0, TEq memeberEq)
			:base(initial,binder)
		{
			_annilator = _annilator0;
			_elEq = elEq;

			
		}
	


	}


	public class Accumulator1<T, TOp, TEq>
		:_AccumulatorA1<T,TOp,TEq>

		,
		AccumulatorI1<T,TOp,TEq>
		
		where TOp : nilnul.obj.op_.BinaryI<T>
		where TEq : IEqualityComparer<T>


	{

		public Accumulator1(T initial, TOp binder, T annilator0, TEq eq):base(initial,binder,annilator0, eq)
		{
			
		}

	}

	public class Accumulator1<T, TOp>
		:_AccumulatorA1<T,TOp,IEqualityComparer<T>>

		,
		AccumulatorI1<T,TOp>
		
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
	
		public Accumulator1(T initial, TOp binder, T annilator0, IEqualityComparer<T> memberEq):base(initial,binder,annilator0, memberEq)
		{
			
		}
		


	}


	public class Accumulator1<T>
		:
		Accumulator1<T, nilnul.obj.op_.BinaryI<T>>
		,
		AccumulatorI1<T>
	{

		public Accumulator1(T initial, nilnul.obj.op_.BinaryI<T> accumulator ,T annilator1, IEqualityComparer<T> elEq) : base(initial, accumulator,annilator1, elEq)
		{

		}

	}



}
