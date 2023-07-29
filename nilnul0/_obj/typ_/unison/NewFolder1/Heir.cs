using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.singular
{
	/// <summary>
	/// note Singuton;s ctor is private.  So you cannot heir that; but you can herit this.
	/// </summary>
	/// <typeparam name="THeir"></typeparam>
	///
	[Obsolete(nameof(nilnul._obj.typ_.unison.TraitByInherit<THeir>))]
	public class Heir<THeir>
		where THeir:new()
	{

		static public THeir Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<THeir>.Instance;
			}
		}

	}
}
