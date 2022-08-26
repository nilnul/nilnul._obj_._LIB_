using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started._main1toe
{
	/// <summary>
	/// keep last one. enumerate all before.
	/// Assume a finite seq.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	 public class KeepLast<T>
		:nilnul.obj.Box1< IEnumerator<T> >
	{
		T _current;

		/// <summary>
		/// only take this when main is enumeraed over.
		/// </summary>
		public T toe {
			get {
				return _current;
			}
		}


		public KeepLast(IEnumerator<T> val) : base(val)
		{
		}

		public KeepLast(IEnumerable<T> val) : base(val.GetEnumerator())
		{
		}
		public IEnumerable<T> main()
		{
			boxed.MoveNext();
			 _current = boxed.Current;

			while (boxed.MoveNext())
			{
				yield return _current;
				 _current = boxed.Current;

			}


			
		}
	
	}
}
