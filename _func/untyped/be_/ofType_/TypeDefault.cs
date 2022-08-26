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
	public class Typed<T> : untyped.be_.OfType
		//where T : new()
	{
		public Typed() : base(typeof(T))
		{
		}


		static public Typed<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Typed<T>>.Instance;
			}
		}

	}
}
