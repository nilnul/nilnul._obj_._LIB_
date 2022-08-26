using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.phrase_.json_
{
	static public class _IndentX
	{
		static public string JsonIndent(this object obj) {
			return Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
		}
	}
}
