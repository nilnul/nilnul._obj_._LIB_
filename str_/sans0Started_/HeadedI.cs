using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sans0Started_
{

	public interface StartedI<out T, out TStr>
		:
		Sans0StartedI<T>,
		_started_.HeadI<T>
		,_started_.TailI<T,TStr>
		where TStr:
		StrI2<T>
		,
		Sans0StartedI<T>

	{

	}

	public interface StartedI<out T>
		:StartedI<T, nilnul.obj.str_.Sans0StartedI<T>>
	{

	}

	public class Started<T, TStr> 
		:StartedI<T,TStr>
		where TStr:nilnul.obj.StrI2<T>,Sans0StartedI<T>
	{


		public Started(T head, TStr tail )
		{
			_head = head;
			_tail = tail;

		}
		private T _head;
		public T head
		{
			get
			{
				return _head;
				//throw new NotImplementedException();
			}
		}

		private TStr _tail;

		public TStr body
		{
			get
			{
				return _tail;
				//throw new NotImplementedException();
			}
		}

		public Sans0StartedI<T> toSans0Started()
		{
			return this;
		}
	}

	public class Started<T> : Started<T, nilnul.obj.str_.Sans0StartedI<T>>
	{
		public Started(T head, Sans0StartedI<T> tail) : base(head, tail)
		{
		}
	}
}
