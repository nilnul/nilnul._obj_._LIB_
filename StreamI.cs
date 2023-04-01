using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface StreamI_blank :IStream
	{
	}

	public interface StreamI_blank_ofEl<out T> : StreamI_blank,IStream< T> {

 }
}
