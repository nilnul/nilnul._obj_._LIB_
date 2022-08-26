using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.obj.FuncI3;


namespace nilnul.obj.func_.typed_
{
	/// <summary>
	/// generi is regarded as subtype of <see cref="IFunc"/>, as <see cref="IFunc"/> with no type constaints can accomdate any derived generics and thus form a closure. Generi cannot form closure as the returned type, in gerenic sense, might be diffrent than pre-specified type.
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// the func is typed generically partially or wholely. This doesnot mean that they are typed the same; They have different generic types and their type doesnot equal.
	public interface IGeneri<out TRet>
		:obj.IFunc
		,
		obj.func_.ITyped
	{

	}
	/// <summary>
	/// typed lambda.
	/// <see cref="System.Linq.Expressions.Expression<T>"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface GeneriI< T>:IFunc
		,IGeneri<T>

	{
		obj.func.be_.typed_.generi.vow.Ee<T> generi { get; }
	}

	public class Generi<T> :
		obj.func.be_.typed_.generi.vow.Ee<T>
		,
		GeneriI<T>
	{
		public Generi(F val) : base(val)
		{
		}
		public Generi(obj.Func3 val) : base(val)
		{
		}

		public Generi(Expression<T> sys):this(new obj.Func3(sys))
		{
		}


		public obj.func.be_.typed_.generi.vow.Ee<T> generi => this;

		static public implicit operator Generi<T>(Expression<T> sys) {
			return new Generi<T>(sys);
		}
	}
}
