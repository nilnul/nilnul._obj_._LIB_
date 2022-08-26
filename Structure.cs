using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// structure is not only many objs, but also how to organize there, by relations among them for example.
	/// we have a tree structure to organize the prjs in a sln. Unfortunately this structure has no order -- even we can order the folders under a sln by their default lexical order, we cannot include a custom order into this.
	/// on the other hand, linear ordered objs is of a different Stucture.
	/// eg:
	///		comparer, or in other words: linearOrder
	///		table
	///		tree (node is not ordered)
	/// </summary>
	/// <remarks>
	/// any structure can be serialized to a linear structure.
	/// </remarks>
	public interface IStructure
	{
	}
}
