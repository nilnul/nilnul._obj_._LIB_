using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.comp;

namespace nilnul.obj.border.comp
{
	static public class _ReX
	{
		static public bool Le<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			obj.BorderI<T> border
			,
			T borderClosed
		) {
			return  comp.Le(
				border
				,
				 obj.Border<T>.CloseOf(borderClosed)
			);
		}
		static public bool Le<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			T borderClosed
			,
			obj.BorderI<T> border
		) {
			return  comp.Le(
				obj.Border<T>.CloseOf(borderClosed)
				,

				border
			);
		}

		static public bool Lt<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			obj.BorderI<T> border
			,
			T borderClosed
		) {
			return  comp.Lt(
				border
				,
				 obj.Border<T>.CloseOf(borderClosed)
			);
		}
		static public bool Lt<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			T borderClosed
			,
			obj.BorderI<T> border
		) {
			return  comp.Lt(
				 obj.Border<T>.CloseOf(borderClosed)
				,
				border
			);
		}


		static public bool Gt<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			obj.BorderI<T> border
			,
			T borderClosed
		) {
			return  comp.Gt(
				border
				,
				 obj.Border<T>.CloseOf(borderClosed)
			);
		}

		static public bool Gt<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			T borderClosed
			,
			obj.BorderI<T> border
		) {
			return  comp.Gt(
				 obj.Border<T>.CloseOf(borderClosed)
				,
				border
			);
		}

		static public bool Ge<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			obj.BorderI<T> border
			,
			T borderClosed
		) {
			return  comp.Ge(
				border
				,
				 obj.Border<T>.CloseOf(borderClosed)
			);
		}

		static public bool Ge<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			T borderClosed
			,
			obj.BorderI<T> border
		) {
			return  comp.Ge(
				 obj.Border<T>.CloseOf(borderClosed)
				,
				border
			);
		}

		static public bool Eq<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			obj.BorderI<T> border
			,
			T borderClosed
		) {
			return  comp.Eq(
				border
				,
				 obj.Border<T>.CloseOf(borderClosed)
			);
		}
		static public bool Eq<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			T borderClosed
			,
			obj.BorderI<T> border
		) {
			return  comp.Eq(
				 obj.Border<T>.CloseOf(borderClosed)
				,
				border
			);
		}

		static public bool Ne<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			obj.BorderI<T> border
			,
			T borderClosed
		) {
			return  comp.Ne(
				border
				,
				 obj.Border<T>.CloseOf(borderClosed)
			);
		}

		static public bool Ne<T>(
			this IComparer<obj.BorderI<T>> comp
			,
			T borderClosed
			,
			obj.BorderI<T> border
		) {
			return  comp.Ne(
				 obj.Border<T>.CloseOf(borderClosed)
				,
				border
			);
		}



	}
}
