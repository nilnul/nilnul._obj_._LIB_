using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.dense.border.co.be_
{
	public class Dwelt<T,TBorder>
		:
		obj.border.co.BeA<T,TBorder>
		,
		obj.border.co.be_.IDwelt
		where TBorder: obj.BorderI<T>
		where T: obj_.IDense
	{

		private obj.border.co.be_.Single<T,TBorder> _singleton;

		public obj.border.co.be_.Single<T,TBorder> singleton
		{
			get { return _singleton; }
			set { _singleton = value; }
		}

		private obj.border.co.be_.Spanned<T,TBorder> _spanned;

		public obj.border.co.be_.Spanned<T,TBorder> spanned
		{
			get { return _spanned; }
			set { _spanned = value; }
		}

		public Dwelt(
			obj.border.co.be_.Single<T,TBorder> singleton
			,
			obj.border.co.be_.Spanned<T,TBorder> spanned
		)
		{
			this._singleton = singleton;
			this._spanned = spanned;
		}

		public override bool be(in (TBorder, TBorder) obj)
		{
			return _singleton.be(obj) && _spanned.be(obj);
			//throw new NotImplementedException();
		}
	}
}
