using System;
using System.Collections;
using System.Collections.Generic;

namespace nilnul.obj.vec_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		troika
	///		trio
	public class Tro<T>
		:
		Tuple<T, T, T> // we neednot to repeat the typeparameter thrice.
		,
		VecI<T>
	{
		public Tro(T item1, T item2, T item3) : base(item1, item2, item3)
		{
		}
		public Tro((T, T, T) x) : this(x.Item1, x.Item2, x.Item3)
		{

		}


		//static public implicit operator Tro<T>(
		//	Tuple<T,T,T> x
		//){
		//	return new Tro<T>(x);
		//}
		//static public implicit operator Tuple<T,T,T>(
		//	Tro<T> x
		//){
		//	return new Tuple<T,T,T>(x.Item1,x.Item2,x.Item3);
		//}

		static public implicit operator Tro<T>(
			(T,T,T) x
		){
			return new Tro<T>(x);
		}
		static public implicit operator (T,T,T)(
			Tro<T> x
		){
			return (x.Item1,x.Item2,x.Item3);
		}

		public IEnumerator<T> GetEnumerator()
		{
			yield return base.Item1;
			yield return base.Item2;
			yield return base.Item3;
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
