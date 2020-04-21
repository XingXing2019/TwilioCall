using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace TwilioCall.Api
{
    public class TwilioWrapperClient : IClient
    {
        private readonly string _sid;
        private readonly string _auth;

        public bool IsInitialized { get; set; }
        public bool CanSendSms => true;
        public bool CanCall => true;
        public bool FromNumberRequired => true;
        
        public TwilioWrapperClient(string sid, string auth)
        {
            _sid = sid;
            _auth = auth;
        }
        
        public void Init()
        {
            TwilioClient.Init(Credentials.TWILIO_ACC_SID, Credentials.TWILIO_AUTH_TOKEN);
            IsInitialized = true;
        }

        public async Task<IResponse> CallAsync(string from, string to, string msg)
        {
            var fromPhoneNumber = new PhoneNumber(from);
            var toPhoneNumber = new PhoneNumber(to);
            var body = WebUtility.UrlEncode(msg);

            var call = await CallResource.CreateAsync(
                to: toPhoneNumber,
                from: fromPhoneNumber,
                url: new Uri($"https://handler.twilio.com/twiml/EH551ae48b51b996d131ebe9a19372ad6f?body={body}"),
                timeout: 30);

            Thread.Sleep(1000 * 10);
            call = CallResource.Update(status: CallResource.UpdateStatusEnum.Completed, pathSid: call.Sid);

            return new CallResponse(call);
        }

        public async Task<IResponse> SendSmsAsync(string from, string to, string msg)
        {
            var fromPhoneNumber = new PhoneNumber(from);
            var toPhoneNumber = new PhoneNumber(to);

            var message = await MessageResource.CreateAsync(
                to: toPhoneNumber,
                from: fromPhoneNumber,
                body: msg);

            return new TextResponse(message);
        }

        public override string ToString()
        {
            return "Twilio API";
        }
    }
}
