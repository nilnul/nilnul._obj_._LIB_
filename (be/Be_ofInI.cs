using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	public interface BeI_ofIn<  T>
		:
		nilnul.obj.IBe<T>
	{
		bool be(in T val);
	}

	public abstract class BeA_ofIn<T> : BeI_ofIn<T>
	{
		public abstract bool be(in T val);
		public bool be(T val) { return be(in val); }
	}
}
