using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/*
公元一世纪的时候，希腊的普鲁塔克提出了一个问题：如果忒修斯船上的零件被逐渐替换，直到所有的零件都不是原来的零件，那么这艘船还是原来的那艘船吗？

这就是人类历史上的忒修斯悖论.

		So we would use an ID, a reference not in physical world, but in infomational world, to stand for an object such that even all components of that object are replaced, the ID remains stable and stills points to that object. The ID is not change, the object is still the object, even the physical whole and parts has changed, the informational one is not changed -- and that's the id, and that's the object.
		 */

	/// <summary>
	/// interface is for reading. for mutation, use class.
	/// </summary>
	///
	public interface IObj { }
	public interface ObjI:IObj
	{

	}

}
