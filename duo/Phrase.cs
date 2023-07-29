using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo
{
	/// <summary>
	/// we first do the joining here; to enclose it, we need to do that later;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Phrase<T,T1>
		:
		nilnul.obj.duo.PhraseI<T,T1>
		
	{
		public const char SEP4DEFAULT = ':';
		private string _separator;

		public string separator
		{
			get { return _separator; }
			set { _separator = value; }
		}

		public Phrase(string separator)
		{
			_separator = separator;
		}

		public Phrase(char sep):this(sep.ToString())
		{
		}
		/// <summary>
		/// like a dict|map entry;
		/// vs:<see cref="obj.co._PhraseX"/>, whic is a <see cref="vec_.ICo"/>
		/// </summary>
		public Phrase():this(SEP4DEFAULT)
		{
		}

		public string phrase(Duo<T> obj)
		{

			return $"{obj.Item1}{_separator}{obj.Item2}";
			throw new NotImplementedException();
		}

		public string phrase(T obj, T1 obj1)
		{

			return $"{obj}{_separator}{obj1}";
			//throw new NotImplementedException();
		}

		public string phrase(Tuple<T, T1> obj)
		{
			return phrase(obj.Item1,obj.Item2);

			//throw new NotImplementedException();
		}

		/// <summary>
		/// using ":";
		/// </summary>
		/// <remarks>
		///"->" is 2-gram, somewhat complex. <see cref="join_.ThinArraw{T}"/>
		/// </remarks>
		static public Phrase<T,T1>  Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Phrase<T,T1> >.Unison;
			}
		}

	}
}
