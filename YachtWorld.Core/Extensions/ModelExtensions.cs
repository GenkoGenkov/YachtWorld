using System.Text;
using YachtWorld.Core.Contracts;

namespace YachtWorld.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this IYachtModel yacht)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(yacht.Title.Replace(" ", "-"));

            return sb.ToString();
        }
    }
}
