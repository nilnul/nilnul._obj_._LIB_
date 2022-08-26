using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started
{
	static public class _Head1torsoX
	{
		static public ( T, IEnumerator<T>) Head1TorsoAsEnumerator<T>(this IEnumerator<T> _started){
			_started.MoveNext();
			return (_started.Current, _started);
			;
		}
		static public ( T, IEnumerable<T>) Head1torso<T>(this IEnumerator<T> _started){
			var t = Head1TorsoAsEnumerator(_started);
			return (t.Item1, nilnul.obj.seq.of_.Enumerator.Seq(t.Item2) );
		}

		static public ( T, IEnumerable<T>) Head1torso<T>(this IEnumerable<T> _started){

			return Head1torso(_started.GetEnumerator());
		}

		//static public ( T, IEnumerable<T>) Head1torso<T>(this IEnumerable<T> _started){
		//	return (_started.First(), _started.Torso());
		//}


	}
}
