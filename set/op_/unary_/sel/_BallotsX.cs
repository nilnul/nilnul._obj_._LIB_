using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.set
{
	/// <summary>
	/// 
	/// </summary>
	static public class _BallotsX
	{

		/// <seealso cref="_CombinateX"/>
		/// <seealso cref="obj.sortie.of_"/>
		/// <summary>
		/// give every possible ballot;
		/// </summary>
		/// <typeparam name="TKey"></typeparam>
		/// <param name="set"></param>
		/// <param name="elEq"></param>
		/// <returns></returns>
		static public IEnumerable<Dictionary<TKey, bool>> _Full_0distinct<TKey>(
			IEnumerable<TKey> set
			,
			IEqualityComparer<TKey> elEq

		) {
			if (set.Any())
			{
				var head = set.First();
				var deheaded = set.Skip(1);
				var full4deheaded = _Full_0distinct<TKey>(deheaded,elEq);
				foreach (var item in full4deheaded)
				{
					var newDict = new Dictionary<TKey, bool>(item, elEq);

					newDict.Add( head,false);
					yield return newDict;
					item.Add(head, true);
					yield return item;
				}
				yield break;
			}
			yield return new Dictionary<TKey, bool>();

		}
		static public IEnumerable<Dictionary<TKey, bool>> _Full_0distinct<TKey>(
			IEnumerable<TKey> set

		) {
			return _Full_0distinct(set, EqualityComparer<TKey>.Default);

		}
		static public IEnumerable<Dictionary<TKey, bool>> _Full_0distinct<TKey,TEq>(
			IEnumerable<TKey> set

		)
			where TEq:IEqualityComparer<TKey>,new()
		{
			return _Full_0distinct(set, 
				 nilnul._obj.typ_._UnisonX<TEq>.Unison
			);

		}


	}
}
