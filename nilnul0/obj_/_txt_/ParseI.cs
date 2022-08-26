using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_._txt_
{
	public interface ParseI<out T> 
	{
		T parse(string s);
	}
}
