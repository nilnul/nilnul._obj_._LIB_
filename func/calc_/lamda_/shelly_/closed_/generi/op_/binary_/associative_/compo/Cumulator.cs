using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.closed_.generi.op_.binary_.associative_.compo
{
	/// <summary>
	/// left associative.
	/// </summary>
	public class Cumulator<T>
		: nilnul.obj.op_.binary.cumulator_.OpDefault<Generi<T>, binary_.associative_.CompoLeft2right<T>
		>
		,
		nilnul.obj.op_.binary.cumulator_.IUnardable  
		,
		nilnul.obj.op_.binary_.associative.cumulator_.IMonoid	//'cuz the above that it's unardable.
	
	{
		public Cumulator( ) : base(func.calc_.lamda_.closed_.generi_.uni_.Nop<T>.Singleton)
		{
		}


		static public Cumulator<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulator<T>>.Instance;
			}
		}


	}
}
