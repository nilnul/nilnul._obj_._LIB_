using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.phrase_
{
	/// <summary>
	/// we first do the joining here; to enclose it, we need to do that later;
	/// </summary>
	/// <remarks>
	/// defaulted to ':', used in prop|attr;
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	public class Join<T> : nilnul.obj.PhraseI<Duo<T>>
		,
		nilnul.obj.PhraseI<Tuple<T,T>>
		,
		nilnul.obj.duo.PhraseI<T,T>
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
		/// <summary>
		/// like a dict|map entry;
		/// vs:<see cref="obj.co._PhraseX"/>, whic is a <see cref="vec_.ICo"/>
		/// </summary>
		public Join():this("->")
		{
			
		}

		public string phrase(Duo<T> obj)
		{

			return $"{obj.Item1}{_separator}{obj.Item2}";
			throw new NotImplementedException();
		}

		public string phrase(T obj, T obj1)
		{

			return $"{obj}{_separator}{obj1}";
			//throw new NotImplementedException();
		}

		public string phrase(Tuple<T, T> obj)
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
		static public Join<T>  Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Join<T> >.Unison;
			}
		}

	}
}
