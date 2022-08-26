using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.txt_
{
	/// <summary>
	/// when writing, be as strict as possible.
	/// eg:
	///		when creating a dir, check the name to a rule which is stricter than allowed. cuz even a name is allowed, we should not abuse it and only choose a sensible/normalized name.
	///	vs <see cref="nameof(Strict)"/>
	/// </summary>
	public interface IStrict
	{
	}
}
