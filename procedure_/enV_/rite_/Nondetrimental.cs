using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.procedure_.enV_.rite_
{
	/// after all, function, even pure ones, has to return data. The returned data is added to the environment.
	/// <summary>
	/// no updating,or deleting. but only insert. that is, old read is not impacted.
	/// old values are kept and unchanged.
	/// new values are part of the output, which is then naturally becoming the environment as env is all but the system so it absorbes everything.
	/// the output can be absorbed by local env, or global env. global env is the context of global function. So env is related to scope. We cannot have env bigger than global when speaking in the global function; so global env absorbes everything, including the returned value of a function.
	/// Whether to write the output to a storage place is not dependent on the method, but on the env. the env can be readonly, insertonly (keep all the history), or alterInPlace
	/// </summary>
	/// <remarks>
	/// if a call is <see cref="Nonalter"/>, then the change can be regarded as output. We can move the change into output, and let the environment process the output, by, say, inserting a record.
	/// </remarks>
	/// alias:
	///		nonalter.
	///		nondetriment
	///		increment change
	class Nonalter
	{
	}
}
