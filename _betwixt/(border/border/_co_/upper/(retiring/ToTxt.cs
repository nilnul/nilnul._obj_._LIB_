using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border._duo_.upper
{
	[Obsolete()]

	public class _ToTxtX
	{

		static public string ToTxt(bool openFalseCloseTrue) {
			return openFalseCloseTrue ? "]" : ")";
		}
		static public string ToTxt<T>(BorderI<T> border) {
			return $"{border.mark}{ToTxt(border.openFalseCloseTrue)}";
		}
	}
}
