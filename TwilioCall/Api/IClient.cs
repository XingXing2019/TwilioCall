using System.Threading.Tasks;

namespace TwilioCall.Api
{
    public interface IClient
    {
        /// <summary>
        /// Indicates if the Client is Initialized
        /// use <see cref="Init"/> to Initialize the Client
        /// </summary>
        bool IsInitialized { get; set; }

        /// <summary>
        /// Indicates if the Client Supports Sending Text Message
        /// </summary>
        bool CanSendSms { get; }

        /// <summary>
        /// Indicates if the Client Supports Phone Call
        /// </summary>
        bool CanCall { get; }

        /// <summary>
        /// Indicates if the From Number is Required
        /// </summary>
        bool FromNumberRequired { get; }

        /// <summary>
        /// Initializes the Client and Marks the Client as <see cref="IsInitialized"/>
        /// </summary>
        void Init();

        /// <summary>
        /// Calls the Number Asynchronously
        /// </summary>
        /// <param name="from">The From Number can be Optional <see cref="FromNumberRequired"/></param>
        /// <param name="to">The Number to Call</param>
        /// <param name="msg">What We Want to Say</param>
        /// <returns>The Response</returns>
        Task<IResponse> CallAsync(string from, string to, string msg);

        /// <summary>
        /// Send a Text Message Asynchronously
        /// </summary>
        /// <param name="from">The From Number can be Optional <see cref="FromNumberRequired"/></param>
        /// <param name="to">The Number to Text</param>
        /// <param name="msg">The Message</param>
        /// <returns>The Response</returns>
        Task<IResponse> SendSmsAsync(string from, string to, string msg);

        /// <summary>
        /// The Client Name
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}