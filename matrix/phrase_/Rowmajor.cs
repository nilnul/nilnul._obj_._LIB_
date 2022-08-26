using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.phrase_
{
	/// eg:
	///		/\
	///		1
	///		\/
	///		this is a 1*1 matrix. Defaulted from top to bottom, shall not be interpreted as bottom to top.
	///		
	///		^
	///		1,2
	///		this is a 1*2 matrix.
	///		
	///		1,2,3
	///		4,5,6
	///			this is a 2*3 matrix. rowmajor is the default, if cap is not explicitly provided.
	///
	///    /--\
	///    1,3
	///    4,5
	///    ##
	///		this is a 2*2 matrix. "##" means the end, not the beginning. <seealso cref="Colmajor"/>
	///		
	
	class Rowmajor
	{
	}
}
