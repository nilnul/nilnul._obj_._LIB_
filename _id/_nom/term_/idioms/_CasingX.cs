using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom.term_.idioms
{
	[Obsolete(nameof(_term_.IHier) + " shall be taken into account and we need further investigation; deferred to nilnul.dev")]
	static public class _CasingX
	{
		static public string _Lower_assumeIdiomsDwelt(IEnumerable< string> x) {
			return string.Join(
				"_"
				,
				x.Select(a=>a.ToLower())
			);
		}
		static public string _Upper_assumeIdiomsDwelt(IEnumerable< string> x) {
			return string.Join(
				"_"
				,
				x.Select(a=>a.ToUpper())
			);
		}

		static public string _Capital_assumeIdioms(this IEnumerable< string> x) {
			return string.Concat(
				x.Select(t=> _term.idiom.op_.unary_._CasingX._Capital_assumeDwelt(t))
			);
	
		}

		static public string _Camel_assumeIdiomsDwelt(IEnumerable< string> x) {
			return $"{ x.First().ToLower() }{ _Capital_assumeIdioms( x.Skip(1) )  }";
		}

		/// <summary>
		/// eg:
		///		abCdeFghI
		///			this might be ambiguous with
		///				ab Cde Fgh , plus an interface suffix "I"
		///	so this is only used in namespace seg, indicating that we want further subcategory according to some evaluation defined by this.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public string _Uptail_assumeIdiomsDwelt(IEnumerable< string> x) {
			return string.Concat(
				x.Select(
					t=>
					_term.idiom.op_.unary_._CasingX._Tail_assumeDwelt(t)
				)
			);
		}




	}
}
