using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str_.enumable.phrase_
{

	/// <summary>
	/// </summary>
	public  class Join
	{
		private string _separator;

		public string separator
		{
			get { return _separator; }
			set { _separator = value; }
		}
		public Join(string separator)
		{
			_separator = separator;
		}

		public string phrase<T>( IEnumerable<T> vector)
		{
			
			return string.Join(_separator,vector);

		}
		


	}
}
