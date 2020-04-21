using System.Threading.Tasks;

namespace TwilioCall.Api
{
    public interface IResponse
    {
        /// <summary>
        /// Status of Response
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// Indicates if the Status can be Updated
        /// </summary>
        bool CanUpdate { get; }

        /// <summary>
        /// Updates the Response Asynchronously
        /// </summary>
        /// <returns>An Awaitable Task</returns>
        Task UpdateAsync();
    }
}