namespace Plugins.MonoConverters {
	public class IntStringConverter : BaseMonoConverter<int, string> {
		protected override string Inner_Convert(int entryValue) {
			return entryValue.ToString();
		}
	}
}