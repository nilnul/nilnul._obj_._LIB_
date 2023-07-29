using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.obj.stream
{
	static public class _MeshX{

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_mesh">
		/// must be resettable; so you cannot use the enumerator from yield break block where reset is not implemented but enumerator is regenerated each time;
		/// </param>
		/// <returns></returns>
		static public IEnumerable<T> _AsSeq_0mesh<T>(this IEnumerator<IEnumerator<T>> _mesh) {
			BigInteger n = 1; // or 0 if in theory but not perfwise;

			while (true) { 
				//var enumer4all = _mesh.GetEnumerator(); /// or reset if it's implemented;
				BigInteger i = 0;
				while (i++   <n)
				{
					_mesh.MoveNext();
					_mesh.Current.MoveNext();
					yield return _mesh.Current.Current;

				}
				n++;
				_mesh.Reset();
			}
		}

		static public IEnumerable<T> _AsSeq_0mesh<T>(this IEnumerable<IEnumerator<T>> _mesh) {
			BigInteger n = 1; // or 0 if in theory but not perfwise;

			while (true) { 
				var enumer4all = _mesh.GetEnumerator(); /// or reset if it's implemented;
				BigInteger i = 0;
				while (i++   <n)
				{
					enumer4all.MoveNext();
					enumer4all.Current.MoveNext();
					yield return enumer4all.Current.Current;

				}
				n++;
			}
		}

		/// <summary>
		/// to enumerate a mesh, we need the diagonal traversal: image a 2d lattice, start from the origin, fan out till reaching a radius, and then a bigger radius;
		///
		/// Not traverse one by one, as you will never reach the second element of any stream due to being stucked in traversing over streams;
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_mesh"></param>
		/// <returns></returns>
		static public IEnumerable<T> _AsSeq_0mesh<T>(this IEnumerable<IEnumerable<T>> _mesh) {
			return _AsSeq_0mesh(_mesh.Select(x=>x.GetEnumerator()));
			
		}



	}
}
