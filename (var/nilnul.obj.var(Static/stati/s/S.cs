using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.stati.s
{
	public class Headed<T> :Headed<T,var.Stati<T>,SI>
	{
		public Headed(var.Stati<T> head, SI tail):base(head,tail)
		{

		}
		
	}

	public class Headed<TInHead,THead, TTail>:SI
		where THead:obj.var.Stati<TInHead>

		where TTail:SI
	{

		private THead _head;

		public THead head
		{
			get { return _head; }
			set { _head = value; }
		}

		private TTail _tail;

		public TTail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public Headed(THead head, TTail tail)
		{
			_head = head;
			_tail = tail;
		}

		public IEnumerator<StatiI> GetEnumerator()
		{
			yield return _head;
			foreach (var item in _tail)
			{
				yield return item;
			}
			yield break;
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}



	public class Empty:SI
	{
		static public Empty Singleton = SingletonByDefault<Empty>.Instance;

		public IEnumerator<StatiI> GetEnumerator()
		{
			yield break;
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}

	public interface SI
		:IEnumerable<obj.var.StatiI>
	{

	}
}
