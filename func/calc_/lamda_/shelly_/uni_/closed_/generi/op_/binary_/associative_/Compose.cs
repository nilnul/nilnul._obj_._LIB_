using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni_.closed_.generi.op_.binary_
{
	/// <summary>
	/// 
	/// x -> f -> g -> h
	///  
	/// </summary>
	public class _ComposeX
	{
		static public Func<T, T> Compose<T>(Func<T,T> f, Func<T,T> g) {
			return x => g(f(x));	// that is, taking func as filter/workshop, and taking input as rawMaterial,   x->   f  , g
		}

	}

	public class Compose<T>
		:

		binary_.AssociativeI<T>


	{

		/// <summary>
		///  op( op(f,g) ,h) = x ->f ->g ->h = h(g(f(x)))
		///  op( f, op(g,h))
		///		= x ->f  -> g*h
		///		=  t=>h(g(t))    ( f(x) )
		///	so this is associative.
		/// </summary>
		/// <param name="par"></param>
		/// <param name="par1"></param>
		/// <returns></returns>
		public Func<T, T> op(Func<T, T> par, Func<T, T> par1)
		{
			return _ComposeX.Compose(par, par1);
			//throw new NotImplementedException();
		}

		public Generi<T> op(Generi<T> par, Generi<T> par1)
		{
			return new Generi<T>(
				x=> (T) ( par1.ee.ee.ee.Compile().DynamicInvoke( par.ee.ee.ee.Compile().DynamicInvoke(x))
				)
			);
			//throw new NotImplementedException();
		}

		static public Compose<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Compose<T>>.Instance;
			}
		}

	}
}
