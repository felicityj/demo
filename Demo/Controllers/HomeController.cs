using System.Web.Mvc;

namespace Demo.Controllers {
    using Twilio.TwiML;
    using Twilio.TwiML.Mvc;

    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Title = "Home Page";

            return View();
        }

        [AllowAnonymous]
        public virtual TwiMLResult CalledLive(string bets, string callerName) {
            var call = new TwilioResponse();
            call.Say("Hello");
            call.Say(bets);
            call.Say("Connecting now");
            ////call.Dial(new Client(callerName));
            return new TwiMLResult(call.ToString());
        }
    }

}
