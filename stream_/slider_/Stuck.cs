using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.slider_
{
	/// <summary>
	/// allows pop(n) and prepend null if necessary.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Stuck<T> : nilnul.obj.Box<System.Collections.Generic.Stack<T>>
		,
		nilnul.obj.SliderI<T>
	//, IEnumerable<T>
	{

		/// <summary>
		/// initialize with a stack
		/// </summary>
		/// <param name="val"></param>
		public Stuck(System.Collections.Generic.Stack<T> val) : base(val)
		{


		}
		/// <summary>
		/// empty stack
		/// </summary>
		public Stuck() : this(new System.Collections.Generic.Stack<T>())
		{

		}

		public Stuck(IEnumerable<T> enumable) : this(new System.Collections.Generic.Stack<T>(enumable))
		{

		}


		public void push(T x)
		{
			boxed.Push(x);

		}


		public T current => boxed.Count == 0 ? default(T) : boxed.Peek();

		public void moveNext()
		{

			if (boxed.Count != 0)
			{
				boxed.Pop();
			}





			//throw new NotImplementedException();
		}

		public T pop()
		{
			var r = current;
			moveNext();
			return r;
		}

		

		//public IEnumerator<T> GetEnumerator()
		//{
		//	yield return _current;
		//	moveNext();


		//	//throw new NotImplementedException();
		//}

		//IEnumerator IEnumerable.GetEnumerator()
		//{
		//	return GetEnumerator();
		//	throw new NotImplementedException();
		//}

		internal IEnumerable<T> _popWhile(System.Func<T, bool> p)
		{
			while (p(current))
			{
				yield return current;
				moveNext();
			}
			//throw new NotImplementedException();
		}

		public List<T> popWhile(System.Func<T, bool> p)
		{
			return _popWhile(p).ToList();
			//throw new NotImplementedException();
		}


		internal IEnumerable<T> _pop(int v)
		{

			return _pop((uint)v);

		}
		public List<T> pop(int v)
		{

			return pop((uint)v);

		}

		internal IEnumerable<T> _pop(uint v)
		{
			while (v-- > 0)
			{
				yield return pop();
			}

		}

		public List<T> pop(uint v)
		{
			return _pop(v).ToList();

		}


	}
}
