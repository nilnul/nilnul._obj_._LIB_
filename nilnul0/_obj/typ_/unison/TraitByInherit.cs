using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.unison
{
	/// <summary>
	/// if you class inherit this, your class would have a static Property.
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// <typeparam name="THeir"></typeparam>
	///<see cref="nilnul.obj_.singular.Heir<THeir>"/>;
	public class TraitByInherit<THeir>
		where THeir:new()
	{

		static public TraitByInherit<THeir> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<TraitByInherit<THeir>>.Unison;
			}
		}
	}
}