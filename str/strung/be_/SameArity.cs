using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.be_
{
	/// <summary>
	/// rect
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		rectangular
	public class SameArity<T>
		:
		strung.BeI<T>

	{
		private bool be(IEnumerable<T> item1, IEnumerable<IEnumerable<T>> item2)
		{
			return item2.All( x=>x.Count() == item1.Count());
			//throw new NotImplementedException();
		}

		private bool be((IEnumerable<T>, IEnumerable<IEnumerable<T>>) p)
		{
			return be(p.Item1,p.Item2);
		}

		public bool be(IEnumerable<IEnumerable<T>> obj)
		{
			if (obj.Any())
			{
				return be(
					str_.started._Head1torsoX.Head1torso(obj)
				); ;
			}
			return true;
			//throw new NotImplementedException();
		}


		static public SameArity<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SameArity<T>>.Instance;
			}
		}

	}
}
