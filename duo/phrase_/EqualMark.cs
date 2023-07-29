using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.phrase_
{
	/// <summary>
	/// used in attr
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="T1"></typeparam>
	public class EqualMark<T,T1> : Phrase<T,T1>
	{
		public const char SEP = '=';

		public EqualMark() : base(SEP)
		{
		}



		static public EqualMark<T,T1> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<EqualMark<T,T1>>.Unison;
			}
		}

	

	}
}
