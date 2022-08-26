using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set_
{
	/// <summary>
	/// define a set by a list.
	/// </summary>
	/// <remarks>
	/// note {a,a} is a set; it's equla to {a} or {a,a,a}
	/// </remarks>
	public class OverList<T>: nilnul.obj.SetI<T>
	{

		private List<T> _list;

		public List<T> list
		{
			get { return _list; }
			set { _list = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="list">
		/// repetitive items are allowed. But for the "contains", many occurence and one occurence are the same effect.
		/// </param>
		public OverList(
			
			List<T> list
		)
		{
			_list = list;
		}

		public bool contains(T element)
		{
			return _list.Contains(element);
			//throw new NotImplementedException();
		}
	}
}
