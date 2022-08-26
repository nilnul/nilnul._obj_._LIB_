using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.lamda_.church_
{
	static  class NumeralX
	{
		static public
			Func<
				TF
				,
				Func<TX, TX>
			> Nil<TF, TX>(



		)
		{

			return (TF f) => (TX x) => x;

		}

		static public Func<TX, TX>
			 NilAsFunc<TF, TX>(

			TF f

		)
		{

			return (TX x) => x;

		}

		static public TRet One<TRet, TX>(

			Func<TX, TRet> f
			,
			TX x

		)
		{

			return f(x);

		}


		static public TX Two<TX>(

			Func<TX, TX> f
			,
			TX x

		)
		{

			return f(f(x));

		}


		static public Func<Func<T, T>, Func<T, T>> NilAsLamd<T>(



		)
		{

			return (Func<T, T> f) => x => x;

		}

		/// <summary>
		/// applies the operation once.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		static public Func<Func<T, T>, Func<T, T>> OneAsFunc<T>(



		)
		{

			return (Func<T, T> f) => x => f(x);

		}
		/// <summary>
		/// applies the operation twice.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		static public Func<Func<T, T>, Func<T, T>> TwoAsFunc<T>(



		)
		{

			return (Func<T, T> f) => x => f(f(x));

		}

		static public Func<Func<T, T>, Func<T, T>> ThreeAsFunc<T>(



		)
		{

			return (Func<T, T> f) => x => f(f(f(x)));

		}





	}
}
