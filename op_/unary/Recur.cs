using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary
{
	public interface IRecur {

	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// vs: <seealso cref="nameof(op_.binary.ICumulator<typeparamref name="T"/>)"/>
	/// </remarks>
	public interface IRecur<T>:IRecur { }
	/// <summary>
	/// recursively apply an op on the previous result. The first result is preset as the initial parameter.
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// vs:<seealso cref="nameof(op_.binary.CumulatorI{T})"/>
	///		cumulator convert a str to an obj.
	///		recur converts an obj into a stream/sequence.
	/// </remarks>
	///

	public interface IRecur<T,TOp>
		:IRecur<T>
		where TOp: obj.op_.IUnary<T>
	{

	}


	public interface RecurI<T,TOp>
		:_recur_.InitialI<T>
		,
		_recur_.OpI<TOp>
		,
		IRecur<T,TOp>
		where TOp: obj.op_.UnaryI<T>
	{

	}

	public interface RecurI<T>
		:
		RecurI<T, obj.op_.UnaryI<T>>
		//,
		//_recur_.InitialI<T>
		//,
		//_recur_.OpI_ovObj<T>
	{

	}

	public class Recur<T, TOp>
		:
		_recur_.InitialA<T>
		//,
		//_recur_.OpI<TOp>
		,
		RecurI<T, TOp>
		//,		nilnul.obj.stream_.SliderI<T>   /// this is deferred, such that the <see cref="nameof(Recur{T, TOp})"/> can be parameterized on other par such as <typeparam name="T">initial</typeparam> can be parameterized as in Julia Set.

		where TOp: obj.op_.UnaryI<T>

	{

		public Recur(T initial0,TOp op0) : base(initial0)
		{
			_op = op0;

		}
		private TOp _op;
		public TOp op => _op;

	
	}
	public class Recur<T> : Recur<T, op_.UnaryI<T>>
	{
		public Recur(T initial0, UnaryI<T> op0) : base(initial0, op0)
		{
		}
	}
}
