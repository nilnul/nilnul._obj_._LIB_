using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// change the state of the obj by side effect. That means, we don't return anything; but the operand, say storage container, has changed its content.
	/// </summary>
	/// <remarks>
	/// vs:
	///		<see cref="nameof(nilnul.obj.op_.IUnary)"/>
	///			op is intended to return a changed object. The original object is not chaned.
	///		
	///		
	/// </remarks>
	/// 
	public interface IAct { }
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">type of the object to be changed.</typeparam>
	public interface IAct<T> :IAct{ }
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="">also known as:
	/// Alter
	/// ,
	/// Operate
	/// </seealso>
	public interface ActI<T>
	{
		void act(ref T obj);
	}

	public abstract class ActA<T> : ActI<T>
	{
		public abstract void act(ref T obj);
		public T op(ref T obj) {
			act(ref obj);
			return obj;
		}
	}
	public interface ActI : ActI<object> {

	}
}
