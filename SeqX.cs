using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a str or a stream. conceptualy same as <see cref="nameof(IEnumerable{T})"/>
	/// </summary>
	/// <remarks>
	/// recursion might be terminated by the termination condition.
	/// if the recursion is finite, it's a str
	/// if the recursion is infinite, it's a stream
	/// sometimes it is hard to tell whether it is finite or infinite. eg:Collatz seqence.
	/// </remarks>
	public interface ISeq { }	//for marker interface, the body is inline.

	public interface ISeq<T>:ISeq { }
	/*
	 if it's finite, we call it Repeated;
	if it's infinite, we call it Recured.
	 */
	/// <summary>
	/// 
	/// </summary>
	static public class SeqX
	{
		static public void Each<T>(this IEnumerable<T> x, Action<T> action) {
			foreach (var item in x)
			{
				action(item);
			}
		}

		/// <summary>
		/// make this greedy rather than lazy
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="x"></param>
		static public void Each<T>(this IEnumerable<T> x) {
			foreach (var item in x)
			{
			}
		}

	}
}
