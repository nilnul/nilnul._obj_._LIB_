using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._str.recur_.headed0Sans_
{

	public interface HeadedI<T, TStr> :
		Headed0SansI<T>,
		_headed_.HeadI<T>
		,_headed_.TailI<T,TStr>
		where TStr:RecurI<T>

	{

	}


	public class Headed<T, TStr> 
		:HeadedI<T,TStr>
		where TStr:nilnul.obj._str.RecurI<T>
	{


		public Headed(T head, TStr tail )
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

		public TStr tail
		{
			get
			{
				return _tail;
				//throw new NotImplementedException();
			}
		}

		public Headed0SansI<T> toHeaded0Sans()
		{
			return this;
		}
	}
}
