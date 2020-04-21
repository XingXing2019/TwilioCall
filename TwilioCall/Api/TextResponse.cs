using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace TwilioCall.Api
{
    public class TextResponse : IResponse
    {
        private string m_sid;
        public string Status { get; set; }
        public bool CanUpdate => true;

        public TextResponse(MessageResource message)
        {
            SetMessage(message);
        }

        private void SetMessage(MessageResource message)
        {
            m_sid = message.Sid;
            Status = message.Status.ToString();
        }

        public async Task UpdateAsync()
        {
            var message = await MessageResource.FetchAsync(m_sid);
            SetMessage(message);
        }
    }
}