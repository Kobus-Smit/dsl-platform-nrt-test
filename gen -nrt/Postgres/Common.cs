
namespace Common
{
	using global::System.Threading;
	using global::Revenj.Utility;

	internal static partial class Utility
	{
		private static readonly ThreadLocal<ChunkedMemoryStream> ThreadLocalStream = new ThreadLocal<ChunkedMemoryStream>(() => ChunkedMemoryStream.Static());
		internal static ChunkedMemoryStream UseThreadLocalStream()
		{
			var local = ThreadLocalStream.Value;
			local.Reset();
			return local;
		}
	}
}