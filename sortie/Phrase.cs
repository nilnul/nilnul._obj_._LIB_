using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._sortie_;
using nilnul.obj.str.be_.distinct.vow;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.obj.sortie
{
	static public class _PhraseX
	{
		/*
		  we use the pair "<a,b,c>"
		 */
		/// <summary>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_sortie"></param>
		/// <returns></returns>
		static public string _Phrase<T>(IEnumerable<T> _sortie) {
			return $"<{ nilnul.objs._PhraseX._Phrase(_sortie) }>";
		}

	}
	


}
