using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	///This "Be" is corresponding to nilnul.collection_.Axiomatic, and it determines two complementary subsets of all the instances of a type.
	///For finite <see cref="nameof(nilnul.obj.ISet)"/> is finite.
	///For enumerable, <see cref="nameof(nilnul.obj.collection_.Discrete)"/> is finite or countable infinte.  <seealso cref="nameof(nilnul.obj.ISeq)"/>, including <see cref="nameof(nilnul.obj.IStream)"/>
	///
	/// </summary>
	public interface IBe {

	}
	public interface IBe<in Obj>
		:IBe
	{

	}

	[Obsolete("avoid name conflicting with _nilnul_::")]
	public  interface BeI<in T>
		//:BeI1<TDomain>
		:IBe<T>
	{
		bool be(T obj);
	}
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	public interface BeI1<in T>:BeI<T>
	{

	}

	//public abstract class BeA< T>:BeI1<T>
	//{

	//}
}
