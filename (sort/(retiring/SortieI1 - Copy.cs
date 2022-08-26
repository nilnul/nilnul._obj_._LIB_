using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._sortie_;
using nilnul.obj.str.be_.distinct.vow;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.obj
{
	
	public interface SortieI1<T>
		:
		nilnul.obj.SortieI
		,
		nilnul.obj._sortie_.StrI_ele<T>
	{


	}

	public class Sortie1<T> :
		nilnul.obj.str.be_.distinct.vow.En<T>
		,
		SortieI1<T>
	{
		public Sortie1(IEqualityComparer<T> eq, obj.StrI1<T> val) : base( eq,val)
		{
		}

		public obj.str.be_.distinct.vow.En<T> str => this;
	}


	public interface SortieI1<T, TEq>
		:
		SortieI1<T>
		where TEq:IEqualityComparer<T>,new()
	{
	}

	public class Sortie1<T, TEq> :
		Sortie1<T>
		,
		SortieI1<T, TEq>

		where TEq : IEqualityComparer<T>, new()
	{
		public Sortie1(obj.StrI1<T> val) : base(nilnul.obj_.Singleton<TEq>.Instance,  val)
		{
		}

	}

	public class Sortie1<T, TEq,TStr> :
		nilnul.obj.str.be_.distinct.vow.En<T,TEq,TStr>
		,
		_sortie_.StrI<nilnul.obj.str.be_.distinct.vow.En<T, TEq, TStr>>

		where TEq : IEqualityComparer<T>, new()
		where TStr: nilnul.obj.StrI1<T>
	{
		public Sortie1(TStr val) : base(  val)
		{

		}

		public En<T, TEq, TStr> str => this;
	}



}
