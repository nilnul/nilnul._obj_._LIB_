using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.phrase_
{
	public class Join<T> : nilnul.obj.PhraseI<Duo<T>>
		,
		nilnul.obj.PhraseI<Tuple<T,T>>
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

		public string phrase(Duo<T> obj)
		{

			return $"{obj.Item1}{_separator}{obj.Item2}";
			throw new NotImplementedException();
		}

		public string phrase(T obj, T obj1)
		{

			return $"{obj}{_separator}{obj1}";
			throw new NotImplementedException();
		}

		public string phrase(Tuple<T, T> obj)
		{
			return phrase(obj.Item1,obj.Item2);

			throw new NotImplementedException();
		}
	}
}
