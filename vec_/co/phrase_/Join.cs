using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.couple.phrase_
{
	public class Join :
		nilnul.obj.PhraseI<Tuple<T,T1>>
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

		

		public string phrase(T obj, T1 obj1)
		{

			return $"{obj}{_separator}{obj1}";
			throw new NotImplementedException();
		}

		public string phrase(Tuple<T, T1> obj)
		{
			return phrase(obj.Item1,obj.Item2);

			throw new NotImplementedException();
		}
	}
}
