using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._border_
{
	public interface MarkI<T>
	{
		T mark { get; }
	}

	public abstract class MarkA<T> : MarkI<T>
	{
		private T _mark;
		public MarkA(T mark)
		{
			_mark = mark;
		}
		public T mark
		{
			get
			{
				return _mark;
				throw new NotImplementedException();
			}
		}
	}
}
