using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{
	public interface IHeaded
		:IObjs
	{
	}

	public interface HeadedI<T>
		:IEnumerable<T>
		,
		IHeaded
	{
		T head { get; }
		IEnumerable<T> body { get; }
	}

	public class Headed<T> :
		obj.Box1<(T, IEnumerable<T>)>
		,
		HeadedI<T>
	{
		public Headed((T, IEnumerable<T>) val) : base(val)
		{
		}

		public T head => boxed.Item1;

		public IEnumerable<T> body => boxed.Item2;

		public IEnumerator<T> GetEnumerator()
		{
			yield return head;
			foreach (var item in body)
			{
				yield return item;

			}


		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

}
