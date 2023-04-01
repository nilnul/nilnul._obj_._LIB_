namespace nilnul.obj.stream_
{
	/// <summary>
	/// This is more like <seealso cref="nameof(IEnumerator{T})"/> that <see cref="nameof(IEnumerable{T})"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface SliderI<T> :
		ISlider
		,
		SliderI_blank,

		nilnul.obj.StreamI2<T>
		,
		_slider_.SkimI<T>
		,
		nilnul.obj.stream_._slider.CursorI<T>
		, nilnul.obj.SliderI<T>
	{
		
	}
}
