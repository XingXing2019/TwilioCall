using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace TwilioCall.Api
{
    public class CallResponse : IResponse
    {
        private string m_sid;
        public string Status { get; set; }
        public bool CanUpdate => true;

        public CallResponse(CallResource call)
        {
            SetCall(call);
        }

        private void SetCall(CallResource call)
        {
            m_sid = call.Sid;
            Status = call.Status.ToString();
        }
        public async Task UpdateAsync()
        {
            var call = await CallResource.FetchAsync(m_sid);
            SetCall(call);
        }
    }
}