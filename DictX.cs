using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	[Obsolete("nilnul.rel_.Dict, in that dict is the relation based on set.")]
	static public class DictX
	{
		static public string Phrase<TKey,TVal>(this Dictionary<TKey,TVal> dict) {
			return "{"+
				string.Join(
					","
					,
					dict.Select(
						e=> nilnul.obj.couple.KeyVal.Phrase(e) 
					)
				)
				+
				"}";
		}

		static public void AddEntry<TKey,TVal>(this Dictionary<TKey,TVal> dict, KeyValuePair<TKey,TVal> keyValues) {
			dict.Add(keyValues.Key,keyValues.Value);
		}

		static public void AddRange<TKey,TVal>(this Dictionary<TKey,TVal> dict, IEnumerable<KeyValuePair<TKey,TVal>> keyValues) {
			keyValues.Each(
				x=>dict.AddEntry(x)
			);
		}



	}
}
