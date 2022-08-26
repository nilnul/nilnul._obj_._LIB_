using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func.untyped.be_.ofType_
{
	
	/// <summary>
	/// typeDefault ==> typeD ==> typed
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Typed_lambda<T> : untyped.be_.OfType_lambda
		//where T : new()
	{
		public Typed_lambda() : base(typeof(T))
		{
		}


		static public Typed_lambda<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Typed_lambda<T>>.Instance;
			}
		}

	}
}
