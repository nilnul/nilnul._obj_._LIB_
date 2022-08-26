using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni.be_.typed_
{
	/// <summary>
	/// typeDefault ==> typeD ==> typed
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Generi<T> : be_.Typed
		//where T : new()
	{
		public Generi() : base(typeof(T))
		{
		}


		static public Generi<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Generi<T>>.Instance;
			}
		}

	}
}
