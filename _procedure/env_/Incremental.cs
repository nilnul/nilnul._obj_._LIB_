using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._procedure.env_
{
	/// <summary>
	/// of immutable data structures. Only add new data is allowed. deletion and updating is not allowed.
	/// eg:
	///		git
	///		
	///	Note we need to allow addingNew as a minimum. As even for pure function, it needs to return something, which is added to the env.
	/// </summary>
	/// <remarks>
	/// by share to reduce space (also by GC, archiving aside old ones.), and by cache to reduce time.
	///		to improve the time/space consumption, the key lies with **sharing**, like what is done in git for blobs, trees, etc.
	///		we can also using cache, which can flatten structure supporting sharing, to more primitive ones.
	///			the byproduct problem with cache is consistency with the original data that is being cached.
	/// </remarks>
	class Incremental
	{
	}
}
