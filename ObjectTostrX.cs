using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul_obj.collection
{
	static public partial class ToStrX
	{
		static public string ToStr(this object o) {
			if (o is IEnumerable)
			{
				//return nilnul_obj.element.collection.CollectionTostrX.Tostr((IEnumerable)o);
				return ToStrX2.ToStr(o as IEnumerable);
			}
			else
			{
				return o.ToString();
			}
		
		}
	}
}
