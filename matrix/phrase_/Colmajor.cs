using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.phrase_
{
	/// <summary>
	/// 
	/// </summary>
	///  eg:
	///		
	///		/        #
	///		|  1     #
	///		\        #
	///				this is a 1*1 matrix.
	///				
	///		/        #
	///		|  1,3   #
	///		|  2,4   #
	///		\        #  this is a 2*2 matrix, colwise, from left to right; it is [ [1,2],[3,4]], not [1,3],[2,4]
	///
	/// 
	///		/        #
	///		|  1,4   #
	///		|  2,5   #
	///		|  3,6   #
	///		\        #  this is a 2*3, not 3*2, matrix. it is [1,2,3], [4,5,6]
	///
	///		#        \
	///		#  4,1   |
	///		#  5,2   |
	///		#  6,3   |
	///		#        /
	///		this is a 2*3, not 3*2, matrix. it is [1,2,3], [4,5,6]. This writes from right to left, as anchient Chinese writing system goes.
	/// 
	///		/       #
	///		  1,4   #
	///		  2,5   #
	///		  3,6   #
	///		\       #  bars omitted.
	///
	///		       
	///		/  1,4  
	///		   2,5   
	///		\  3,6  
	///		         bars omitted. # ommited.
	/// 
	///		
	class Colmajor
	{
	}
}
