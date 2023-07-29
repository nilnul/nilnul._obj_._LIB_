using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	/// <summary>
	/// we first do the joining here; to enclose it, we need to do that later;
	/// </summary>
	static public class _PhraseX
	{
		static public string Commaed<TItem, TItem1>(TItem a, TItem1 b) {
			return $"{a},{b}";
		}
		static public string Commaed<TItem, TItem1>((TItem , TItem1) b) {
			return Commaed(b.Item1,b.Item2);
		}

		static public string Commaed<TItem, TItem1>(KeyValuePair<TItem,TItem1> b) {
			return Commaed(b.Key,b.Value);
		}


		static public string CommaedFenced<TItem, TItem1>(TItem a, TItem1 b) {
			return $"({Commaed(a,b)})";
		}

		static public string CommaedFenced<TItem, TItem1>((TItem , TItem1) b) {
			return CommaedFenced(b.Item1,b.Item2);
		}
		static public string CommaedFenced<TItem, TItem1>(KeyValuePair<TItem,TItem1> b) {
			return CommaedFenced(b.Key,b.Value);
		}

		[Obsolete(nameof(obj.duo.phrase_))]
		static public string ThinArrowed<TKey, TVal>(TKey a, TVal b) {

			return $"{a}->{b}";
		}

		[Obsolete(nameof(obj.duo.phrase_))]
		static public string ThinArrowed<TKey, TVal>((TKey,TVal) a) {

			return ThinArrowed(a.Item1,a.Item2);

		}

		[Obsolete(nameof(obj.duo.phrase_))]
		static public string ThinArrowed<TKey, TVal>(KeyValuePair<TKey,TVal> a) {

			return ThinArrowed(a.Key,a.Value);

		}


	}
}
