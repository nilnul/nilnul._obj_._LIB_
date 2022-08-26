using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.couple
{
	public class KeyVal
	{
		static public string Phrase<TKey,TVal>(KeyValuePair<TKey,TVal> keyVal) {
			return $"{keyVal.Key} -> {keyVal.Value}";
		}

		static public string Phrase4Json<TKey,TVal>(KeyValuePair<TKey,TVal> keyVal) {
			return $"\"{keyVal.Key}\":{keyVal.Value}";
		}

	}
}
