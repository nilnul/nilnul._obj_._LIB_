using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec.to_
{
	/// <summary>
	/// as vec is subtype of str, hence we put vec.ToStr, not str.OfVec
	/// </summary>
	static public class ToStrX
	{
		static public IEnumerable<T> ToStr5<T>(this (T,T) vec) {
			yield return vec.Item1;
			yield return vec.Item2;
		}
		static public IEnumerable<T> ToStr5<T>(this (T,T,T) vec) {
			yield return vec.Item1;
			yield return vec.Item2;
			yield return vec.Item3;
		}
		static public IEnumerable<T> ToStr5<T>(this (T,T,T,T) vec) {
			yield return vec.Item1;
			yield return vec.Item2;
			yield return vec.Item3;
			yield return vec.Item4;
		}

		static public IEnumerable<T> ToStr5<T>(this (T,T,T,T,T) vec) {
			yield return vec.Item1;
			yield return vec.Item2;
			yield return vec.Item3;
			yield return vec.Item4;
			yield return vec.Item5;
		}


	}
}
