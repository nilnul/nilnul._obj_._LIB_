using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.re_.sub_.elEqDefault
{
	public class Converse<T,TEq>
		: nilnul.obj.re.converse_.ReDefault<IEnumerable<T>, sub_.ElEqDefault<T,TEq>>
		,
		set.ReOfEnumerable<T>
		where TEq:IEqualityComparer<T>,new()
	{


		static public Converse<T,TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Converse<T,TEq>>.Instance;
			}
		}

	}
}
