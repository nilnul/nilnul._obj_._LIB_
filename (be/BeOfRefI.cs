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
	public interface BeOfRefI< T>
		:
		nilnul.obj.IBe<T>
	{
		bool be(ref T val);
	}

	//public abstract class BeA< T>:BeI1<T>
	//{

	//}
}
